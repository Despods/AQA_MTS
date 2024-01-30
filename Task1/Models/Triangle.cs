using System;

internal class Triangle : Shape
{
    private double a;
    private double b;
    private double c;

    public Triangle()
	{
	}

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double Area()
	{
        double temp = Perimetr() / 2;
        double area = Math.Sqrt(temp * (temp - a) * (temp - b) * (temp - c));
		return Math.Round(area);
	}
    public override double Perimetr()
    {
		return (a+b+c);
    }
}
