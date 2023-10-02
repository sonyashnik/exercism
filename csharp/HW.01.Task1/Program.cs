// See https://aka.ms/new-console-template for more information
Console.Write("Enter a dimension of arrays: ");
int i = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[i];
Random random = new Random();
for (int j = 0; j < i; j++)
{
    array1[j] = random.Next(1, i * 10);
}

int[] array2 = new int[i];
for  (int j = 0;j<i; j++)
{
    Console.Write($"Enter array2[{j}]:");
    array2[j] = Convert.ToInt32(Console.ReadLine());
}

int[] array3 = new int[i];
for (int j = 0;j<i; j++)
{
    array3[j] = array1[j] + array2[j];
}

Console.WriteLine("array1:");
foreach (int element in array1) Console.Write($"{element} ");
Console.WriteLine("");
Console.WriteLine("array2:");
foreach (int element in array2) Console.Write($"{element} ");
Console.WriteLine("");
Console.WriteLine("array3:");
foreach (int element in array3) Console.Write($"{element} ");