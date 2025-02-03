var openType = typeof(List<>);
var closedType = openType.MakeGenericType(typeof(int));
var instance = (List<int>)Activator.CreateInstance(closedType);
instance.Add(42);
Console.WriteLine(instance[0]);
