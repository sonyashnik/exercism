using HW._5.Rectangle.Struct;

const int elements = 100;

var rnd = new Random();
Rectangle[] arrOfSquares = new Rectangle[elements];
int countOfDuplicates = default;

for (int i = 0; i < elements; i++)
{
    arrOfSquares[i] = new Rectangle(rnd.Next(1, 11));
    Console.WriteLine($"Square[{i}] = {arrOfSquares[i]}");
}

for (int i = 1;i < elements; i++)
{
    if (arrOfSquares[0].Equals(arrOfSquares[i]))
    {
        countOfDuplicates++;
    }
}
Console.WriteLine($"Amount of duplicates is {countOfDuplicates}.");
