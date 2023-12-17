namespace HW._02.Task1
{
    internal class Circle : Shape
    {
        private int _radius;
        public Circle(int radius)
        {
            _radius = radius;
            Name = "circle";
        }

        public override double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }
    }
}