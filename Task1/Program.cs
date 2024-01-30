using System;

public class Program
{
    /*
	Написать иерархию классов «Фигуры».
	Фигура -> Треугольник -> Прямоугольник -> Круг.
	Реализовать метод подсчета площади и периметра для каждого типа фигуры.
	Создать массив из 5 фигур.
	Вывести на экран сумму периметра и площади всех фигур в массиве.
	*/

    static void Main(string[] args)
    {
		Shape[] shapes = new Shape[6];
		shapes[0] = new Triangle(9, 8, 6);
		shapes[1] = new Circle(6);
		shapes[2] = new Rectangle(5,1);
		shapes[3] = new Rectangle(3,2);
		shapes[4] = new Circle(4);
		shapes[5] = new Triangle(11,10,3);

		double areaSum=0;
		double perimetrSum=0;
		Console.WriteLine(shapes[0].Area());
		foreach(Shape shape in shapes)
		{
			areaSum += shape.Area();
			perimetrSum += shape.Perimetr();
            Console.WriteLine($"Площадь: {shape.Area()} , Периметр: {shape.Perimetr()}");
        }
        Console.WriteLine("Общая площадь: {0:f2} , Общий периметр: {1}", areaSum, perimetrSum);

    }
}
