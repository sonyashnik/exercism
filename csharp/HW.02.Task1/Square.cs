namespace HW._02.Task1
{
    internal class Square : Shape
    {
        private int _side;
        public Square(int side)
        {
            _side = side;
            Name = "square";
        }

        public override double GetSquare()
        {
            return Math.Pow(_side, 2);
        }
    }
}
