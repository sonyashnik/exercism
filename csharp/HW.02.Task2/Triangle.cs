namespace HW._02.Task2
{
    internal class Triangle : IShape
    {
        private int _height;
        private int _base;

        public string Name { get; set; }

        public Triangle(int height, int @base)
        {
            _height = height;
            _base = @base;
            Name = "triangle";
        }

        public double GetSquare()
        {
            return Math.Round((double)(_base * _height / 2d), 2);
        }

        public string ToString()
        {
            return $"This is {Name}. CLR Type is {GetType()}. Square is {GetSquare()}.";
        }
    }
}
