using _14Reflection;
using System.Reflection;
using System.Runtime.Serialization;

Motorcycle  motorcycle = new Motorcycle();
Console.WriteLine(motorcycle.ToString());

//Create Instance
Type motoType = typeof(Motorcycle); //or Type.GetType("_14Reflection.Motorcycle");
Type ctorParameter = typeof(string);

ConstructorInfo ctor = motoType.GetTypeInfo().DeclaredConstructors
    .First(ct => ct.GetParameters().Any() && ct.GetParameters()[0].ParameterType == ctorParameter);

object[] parametes = new object[] {"Honda"};
object obj = ctor.Invoke(parametes);
Console.WriteLine($"Current type - {obj.GetType()}");
Console.WriteLine(obj.ToString());
Console.WriteLine();
Console.WriteLine("MethodInfo:");

foreach (MethodInfo mi in motoType.GetMethods(BindingFlags.DeclaredOnly
			| BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
{
	string modificator = "";

	// если метод статический
	if (mi.IsStatic)
		modificator += "static ";
	// если метод виртуальный
	if (mi.IsVirtual)
		modificator += "virtual ";

	Console.WriteLine($"{modificator}{mi.ReturnType.Name} {mi.Name} ()");
}
Console.WriteLine();
//Console.WriteLine("FieldInfo:");
//foreach (FieldInfo fi in motoType.GetFields(BindingFlags.Public |
//		 BindingFlags.Static | BindingFlags.FlattenHierarchy))
//{
//	
//	Console.WriteLine($"{fi.Name}");
//}
//FieldInfo fieldInfo = obj.GetType().GetTypeInfo().GetDeclaredField("motoState");
//fieldInfo.SetValue(obj, "old");
//Console.WriteLine(obj);
