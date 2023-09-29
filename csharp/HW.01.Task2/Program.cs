// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] array = new int[10];
for (int i = 0; i < array.Length-1; i++)
{
    Console.Write($"array[{i}] = ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("array = { ");
foreach (int element in array) Console.Write(element+" ");
Console.WriteLine("} ");

Console.Write("Enter one more value: ");
int value = Convert.ToInt32(Console.ReadLine());

Console.Write($"Enter the index in array from 0 to {array.Length - 1}: ");
int index  = Convert.ToInt32(Console.ReadLine());

for (int i = array.Length-1; i > index; i--)
{
    array[i] = array[i-1];
}
array[index] = value;

Console.Write("new array = { ");
foreach (int element in array) Console.Write(element + " ");
Console.Write("} ");