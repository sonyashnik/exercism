namespace HW._02.Task1
{
    internal class Triangle : Shape
    {
        private int _height;
        private int _base;

        public Triangle(int height, int @base)
        {
            _height = height;
            _base = @base;
            Name = "triangle";
        }

        public override double GetSquare()
        {
            return Math.Round((double)(_base * _height / 2d), 2);
        }
    }
}