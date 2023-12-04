
for (int i = 0; i < 5; i++)
{
    var rnd = new Random();
    switch (rnd.Next(0, 3))
    {
        case 0:
            bool radIsValid = false;
            int r = default;
            while (!radIsValid)
            {
                Console.Write("Enter a radius of the circle: ");
                if (int.TryParse(Console.ReadLine(), out r))
                {
                    radIsValid = true;
                }
            }
            var crcl = new Circle(r);
            Console.WriteLine(crcl.ShapeInfo());
            Console.WriteLine();
            break;
        case 1:
            bool sideIsValid = false;
            int s = default;
            while (!sideIsValid)
            {
                Console.Write("Enter a side of the square: ");
                if (int.TryParse(Console.ReadLine(), out s))
                {
                    sideIsValid = true;
                }
            }
            var sqr = new Square(s);
            Console.WriteLine(sqr.ShapeInfo());
            Console.WriteLine();
            break;
        case 2:
            bool heightIsValid = false;
            bool baseIsValid = false;
            int h = default;
            int b = default;
            while (!heightIsValid)
            {
                Console.Write("Enter a height of the triangle: ");
                if (int.TryParse(Console.ReadLine(), out h))
                {
                    heightIsValid = true;
                }
            }
            while (!baseIsValid)
            {
                Console.Write("Enter a base of the triangle: ");
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    baseIsValid = true;
                }
            }
            var trngl = new Triangle(h, b);
            Console.WriteLine(trngl.ShapeInfo());
            break;
        default:
            Console.WriteLine("No shape was found!");
            break;


    }

}


