/*
Реализовать класс Point, который определяет точку на координатной плоскости. В классе реализовать:
внутренние поля x, y;
конструктор с 2 параметрами;
свойства доступа к внутренним полям класса;
метод, выводящий значения внутренних полей класса.
*/
using System.Drawing;
using Task1;
internal class Program
{
    public static void Main(string[] args)
    {
        Point<int> pointInt = new Point<int>(10, 15);
        Point<double> pointDouble = new Point<double>(5.2, 10.5);

        pointInt.PrintInfo();
        pointDouble.PrintInfo();
    }
}
