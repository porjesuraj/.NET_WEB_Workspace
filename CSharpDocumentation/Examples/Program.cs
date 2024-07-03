// See https://aka.ms/new-console-template for more information
using Examples.Library;
using static System.Console;
#region Stack
/*
var stack = new TStack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
*/
#endregion

#region Dynamic List

DynamicList<int> dynamicList1 = new DynamicList<int>(5);
DynamicList<int> dynamicList2 = new DynamicList<int>(5);

dynamicList1.Add(1);
dynamicList1.Add(2);
dynamicList1.Add(3);
dynamicList1.Add(4);
dynamicList1.Add(5);
dynamicList1.Add(6);


dynamicList2.Add(1);
dynamicList2.Add(2);
dynamicList2.Add(3);
dynamicList2.Add(4);
dynamicList2.Add(5);
dynamicList2.Add(6);

WriteLine("d1 & d2 Equals :{0}", dynamicList1 == dynamicList2);
WriteLine("d1 & d2 Not Equals :{0}", dynamicList1 != dynamicList2);




#endregion


#region Delegate



 static double[] Apply(double[] a, Function f)
{
    var result = new double[a.Length];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = f(a[i]);

    }

    return result;
}


double[] test1 = { 2, 4, 5, 6, 7.5, 8 };

var m = new Examples.Library.Multiplier(8);
   var result1 =   Apply(test1, m.Multiply);

Console.WriteLine("Delegate x*x: ");

for (int i = 0; i < result1.Length; i++)
{
    Console.WriteLine($"{test1[i]} : {result1[i]}");

}
#endregion


#region Attribute demo

Console.WriteLine("________________________________________________________________________\n \n \n");


Console.WriteLine("Attribute demo");


Type frameType = typeof(Frame);

Object[] frameClassAttributes  = frameType.GetCustomAttributes(typeof(HelpAttribute), false);


if(frameClassAttributes.Length > 0)
{
   HelpAttribute attr  = (HelpAttribute)frameClassAttributes[0];

    Console.WriteLine($"class help url: {attr.URL} - related topic: {attr.Topic}");


}



 System.Reflection.MethodInfo displayMethod = frameType.GetMethod(nameof(Frame.Display));


object[] methodattr  = displayMethod.GetCustomAttributes(typeof(HelpAttribute), false);


if(methodattr.Length > 0)
{
    HelpAttribute attr = (HelpAttribute)methodattr[0];
    Console.WriteLine($"Display method help url: {attr.URL} - related topic: {attr.Topic}");

}

#endregion

#region Command Line for factorail

Console.WriteLine("________________________________________________________________________\n \n \n");

if (Environment.GetCommandLineArgs().Length > 0)
{
    bool result = int.TryParse(args[0], out int num);
    if(result)
        Console.WriteLine($" factorial of {num} = {Factorial.CalculateFactorial(num)}");
}

#endregion
Console.ReadLine();
