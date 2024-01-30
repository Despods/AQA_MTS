using System;

internal class Circle : Rectangle
{
	private double radius;
	private const double PI = 3.14;
	public Circle(double radius)
	{
		this.radius = radius;
	}

    public override double Area()
    {
        return 2*radius*PI;
    }

    public override double Perimetr()
    {
        return Math.Round(PI*Math.Pow(radius,2));
    }
}
