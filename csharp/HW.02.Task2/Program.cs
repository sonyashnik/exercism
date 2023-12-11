using HW._02.Task2;

public class Program
{
    public static void Main()
    {
        List<IShape> listOfShapes = new List<IShape>();

        for (int i = 0; i < 5; i++)
        {
            var rnd = new Random();
            switch (rnd.Next(0, 3))
            {
                case 0:
                    bool radIsValid = false;
                    int radius = default;
                    while (!radIsValid)
                    {
                        Console.Write($"Shape {i + 1}. Enter a radius of the circle (from 1 to 10): ");
                        if (int.TryParse(Console.ReadLine(), out radius))
                        {
                            if (CheckValue(radius))
                            {
                                radIsValid = true;
                            }
                        }
                    }
                    var crcl = new Circle(radius);
                    listOfShapes.Add(crcl);
                    break;
                case 1:
                    bool sideIsValid = false;
                    int side = default;
                    while (!sideIsValid)
                    {
                        Console.Write($"Shape {i + 1}. Enter a side of the square (from 1 to 10): ");
                        if (int.TryParse(Console.ReadLine(), out side))
                        {
                            if (CheckValue(side))
                            {
                                sideIsValid = true;
                            }
                        }
                    }
                    var sqr = new Square(side);
                    listOfShapes.Add(sqr);
                    break;
                case 2:
                    bool heightIsValid = false;
                    bool baseIsValid = false;
                    int height = default;
                    int @base = default;
                    while (!heightIsValid)
                    {
                        Console.Write($"Shape {i + 1}. Enter a height of the triangle (from 1 to 10): ");
                        if (int.TryParse(Console.ReadLine(), out height))
                        {
                            if (CheckValue(height))
                            {
                                heightIsValid = true;
                            }
                        }
                    }
                    while (!baseIsValid)
                    {
                        Console.Write($"Shape {i + 1}. Enter a base of the triangle (from 1 to 10): ");
                        if (int.TryParse(Console.ReadLine(), out @base))
                        {
                            if (CheckValue(@base))
                            {
                                baseIsValid = true;
                            }
                        }
                    }
                    var trngl = new Triangle(height, @base);
                    listOfShapes.Add(trngl);
                    break;
                default:
                    Console.WriteLine("No shape was found!");
                    break;
            }
        }

        foreach (var shape in listOfShapes)
        {
            Console.WriteLine(shape.ToString());
        }
    }

    public static bool CheckValue(int value)
    {
        return (value > 0 && value <= 10);
    }
}





