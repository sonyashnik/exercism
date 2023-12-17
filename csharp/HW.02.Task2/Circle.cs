namespace HW._02.Task2
{
    internal class Circle : IShape
    {
        private int _radius;
        public string Name { get; set; }

        public Circle(int radius) {
            _radius = radius;
            Name = "circle";
        }

        public double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }

        public string ToString()
        {
            return $"This is {Name}. CLR Type is {GetType()}. Square is {GetSquare()}.";
        }
    }
}