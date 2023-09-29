// See https://aka.ms/new-console-template for more information
 /*
using System.Reflection;
using System.Reflection.Emit;

var asm = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("GentlyTest"), AssemblyBuilderAccess.Run);
var module = asm.DefineDynamicModule("MainModule");
var type = module.DefineType("GentlyFunctions", TypeAttributes.Class | TypeAttributes.Public);
var method = type.DefineMethod("SumTwo", 
    MethodAttributes.Public | MethodAttributes.Static, 
    CallingConventions.Standard, 
    typeof(int), 
    new[] { typeof(int), typeof(int) });
var gen = method.GetILGenerator();
gen.Emit(OpCodes.Ldarg, 0);
gen.Emit(OpCodes.Ldarg, 1);
gen.Emit(OpCodes.Add);
gen.Emit(OpCodes.Ret);

var finType = type.CreateType();

var a = finType.GetMethod(method.Name).Invoke(null, new object[] { 1, 2 });

var pack = new Lokad.ILPack.AssemblyGenerator();

pack.GenerateAssembly(asm, "out/test.dll");

Console.WriteLine(a);
*/

Console.WriteLine("Ki");

