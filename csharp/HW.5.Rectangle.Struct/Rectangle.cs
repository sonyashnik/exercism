namespace HW._5.Rectangle.Struct
{
    internal struct Rectangle
    {
        int height;
        int width;

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public Rectangle(int side)
        {
            this.height = side;
            this.width = side;
        }

        public override string ToString()
        {
            return $"[{height}, {width}]";
        }
    }
}