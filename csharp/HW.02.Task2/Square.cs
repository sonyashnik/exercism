namespace HW._02.Task2
{
    internal class Square : IShape
    {
        private int _side;
        public string Name { get; set; }

        public Square(int side)
        {
            _side = side;
            Name = "square";
        }

        public double GetSquare()
        {
            return Math.Pow(_side, 2);
        }

        public string ToString()
        {
            return $"This is {Name}. CLR Type is {GetType()}. Square is {GetSquare()}.";
        }
    }
}