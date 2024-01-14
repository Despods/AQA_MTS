/*
Создать класс для подсчета площади треугольников
реализовать классы для равнобедренного, равностороннего, прямоугольного и разностороннего треугольника
для каждого использовать свою формулу для подсчета площади
площадь разностороннего треугольника считаем по формуле герона
Создать отдельный класс который будет отвечать за логину создания треугольников. В нем вернуть нужный объект треугольника проверив его стороны
добавить класс квадрат и прямоугольник и логику подсчета площади для него
добавить класс для реализации иерархии фигур
создавь массив квадратов, прямоугольник и треугольников и вывести их площади
*/

using Task1;

internal class Program
{
    static void Main(string[] args)
    {
        FigureCreator figureCreator = new FigureCreator();
        Figure[] figures = new Figure[9];
        figures[0] = figureCreator.CreateTriangle(6, 6, 6);//равносторонний=equilateral 
        figures[1] = figureCreator.CreateTriangle(2, 4, 4);//равнобедренный=isosceles 
        figures[2] = figureCreator.CreateTriangle(3, 4, 5);//прямоугольный=right 
        figures[3] = figureCreator.CreateTriangle(12, 30, 20);//разносторонний=scalene
        figures[4] = figureCreator.CreateTriangle(5, 12, 13);//прямоугольный=right 
        figures[5] = figureCreator.CreateRectangle(2, 3);
        figures[6] = figureCreator.CreateRectangle(5, 5);
        figures[7] = figureCreator.CreateRectangle(3, 9);
        figures[8] = figureCreator.CreateRectangle(10, 10);

        for (int i = 0; i < figures.Length; i++)
        {
            Console.WriteLine($"Площадь фигуры {figures[i]}: {figures[i].getSquare()}");
        }
    }
}