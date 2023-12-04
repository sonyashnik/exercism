public class Shape
{
    protected  string _name { get; set; }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public virtual double GetSquare()
    {
        return 0;
    }
    public string ShapeInfo()
    {
        return $"This is {this.Name}. CLR Type is {this.GetType()}. Square is {this.GetSquare()}.";
    }
}
public class Square : Shape
{
    private int Side { get; set; }
    public Square(int s)
    {
        Side = s;
        this.Name = "square";
    }
    public override double GetSquare()
    {
        return Math.Pow(Side, 2);
    }
}

public class Circle : Shape
{
    private int Radius { get; set; }
  public Circle (int @radius)
    {
        Radius = @radius;
        this.Name = "circle";
    }

    public override double GetSquare()
    {
        return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
    }

}

public class Triangle : Shape
{
    private int Height { get; set; }
    private int Base { get; set; }

    public Triangle(int @height, int @base)
    {
        Height = @height;
        Base = @base;
        this.Name = "triangle";
    }

    public override double GetSquare()
    {
        return Math.Round((double)(Base * Height / 2d), 2);
    }
}