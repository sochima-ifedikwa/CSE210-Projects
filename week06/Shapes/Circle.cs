public class Circle : Shape
{
    private double _radius;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }

}