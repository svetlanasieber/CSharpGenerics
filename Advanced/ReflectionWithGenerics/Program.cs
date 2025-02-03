public class GenericClass<T>
{
    public T Field;
}

// Using reflection to create a generic instance
var typeDef = typeof(GenericClass<>);
var closedType = typeDef.MakeGenericType(typeof(string));
var instance = Activator.CreateInstance(closedType);
((dynamic)instance).Field = "Hello, Reflection!";
Console.WriteLine(((dynamic)instance).Field);
