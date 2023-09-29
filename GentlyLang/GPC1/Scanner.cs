using System.Text;

namespace GPC1; 

public class Scanner {
    private StreamReader _reader;
    
    public Scanner(StreamReader reader) {
        _reader = reader;
    }

    public List<Token> Scan() {
        var result = new List<Token>();
        var buffer = new StringBuilder();

        for (var c = _reader.Read(); c != -1; c = _reader.Read()) {
            if (Char.IsWhiteSpace((char)c))
                continue;
            else if (Char.IsLetter((char)c)) {
                for (var c1 = _reader.Read(); c1 != -1 && Char.IsLetterOrDigit((char)c1); c1 = _reader.Read()) {
                    buffer.Append((char)c1);
                }
                result.Add(new Token(KWType(buffer.ToString()), buffer.ToString()));
                buffer.Clear();
            }
            else if (Char.IsDigit((char)c)) {
                for (var c1 = _reader.Read(); c1 != -1 && Char.IsDigit((char)c1); c1 = _reader.Read()) {
                    buffer.Append((char)c1);
                }
                result.Add(new Token(Token.TokenType.IntLiteral, buffer.ToString()));
                buffer.Clear();
            }
        }

        return result;
    }

    private Token.TokenType KWType(String kw) {
        if (BuiltIn.IsKW(kw))
            return Token.TokenType.Keyword;
        return Token.TokenType.Identifier;
    }

    public record Token(Token.TokenType Type, String? Value) {
        public enum TokenType {
            IntLiteral,
            StringLiteral,
            Keyword,
            ArgGetter,
            Annotation,
            Identifier,
            LParen,
            RParen,
            LCurly,
            RCurly,
            Operator,
            Colon,
            Semi
        }
    }
}