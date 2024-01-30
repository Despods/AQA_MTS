using System;

internal class Rectangle : Triangle
{
    private double a;
    private double b;
	public Rectangle()
    {
    }

    public Rectangle(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public override double Area()
	{
		return a * b;
	}
    public override double Perimetr()
    {
        return 2*(a+b);
    }
}
