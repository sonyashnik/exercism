// See https://aka.ms/new-console-template for more information
bool arrayDimIsValid = false;
int arrayDimension = 0;
while (!arrayDimIsValid)
{
    Console.Write("Enter a valid dimension of arrays: ");
    string consoleInput = Console.ReadLine();
    if (int.TryParse(consoleInput, out int arrDim) && int.IsPositive(arrDim))
    {
        arrayDimIsValid = true;
        arrayDimension = arrDim;
    }
}


int[] array1 = new int[arrayDimension];
Random random = new Random();
for (int j = 0; j < array1.Length; j++)
{
    array1[j] = random.Next(1, arrayDimension * 10);
}

int[] array2 = new int[arrayDimension];
for (int j = 0; j < array2.Length; j++)
{
    Console.Write($"Enter array2[{j}]:");
    array2[j] = Convert.ToInt32(Console.ReadLine());
}

int[] array3 = new int[arrayDimension];
for (int j = 0; j < array3.Length; j++)
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