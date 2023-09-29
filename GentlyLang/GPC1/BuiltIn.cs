namespace GPC1; 

public static class BuiltIn {

    private static List<String> _kws = new List<string>() { };

    private static Dictionary<String, Type> _builtinTypes = new Dictionary<string, Type>() {
        {"int", typeof(int)}
    };

    private static List<String> _mos = new List<string>();

    public static bool IsKW(String word) {
        return _kws.Contains(word);
    }

    public static bool IsBuiltinType(String word) {
        return _builtinTypes.ContainsKey(word);
    }

    public static bool IsMetaOp(String operator_) {
        return _mos.Contains(operator_);
    }
}