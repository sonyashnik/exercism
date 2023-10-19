int[] array = new int[10];
for (int i = 0; i < array.Length-1; i++)
{
    bool loopFlag = false;
    while (!loopFlag)
    {
        Console.Write($"array[{i}] = ");
        if (int.TryParse(Console.ReadLine(), out array[i]))
        {
            loopFlag = true;
        }
    }
    
}
Console.Write("array = { ");
foreach (int element in array) Console.Write(element+" ");
Console.WriteLine("} ");

bool valueIsValid = false;
int value = 0;
while (!valueIsValid)
{
    Console.Write("Enter one more value: ");
    if (int.TryParse(Console.ReadLine(),out value))
    {
        valueIsValid = true;
    }
}

bool indexIsValid = false;
int index = 0;
while (!indexIsValid)
{
    Console.Write($"Enter the index in array from 0 to {array.Length - 1}: ");
    if (int.TryParse (Console.ReadLine(),out index) && int.IsPositive(index) && (index < array.Length))
    {
        indexIsValid = true;
    }
}


for (int i = array.Length-1; i > index; i--)
{
    array[i] = array[i-1];
}
array[index] = value;

Console.Write("new array = { ");
foreach (int element in array) Console.Write(element + " ");
Console.Write("} ");