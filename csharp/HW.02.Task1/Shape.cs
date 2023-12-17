namespace HW._02.Task1 
{ 
    public abstract class Shape
    {
        public string Name { get; set; }

        public virtual double GetSquare()
        {
            return default;
        }

        public override string ToString()
        {
            return $"This is {Name}. CLR Type is {GetType()}. Square is {GetSquare()}.";
        }
    }
}