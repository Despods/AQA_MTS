using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class FigureCreator
    {
        public Triangle CreateTriangle(double lenghtA, double lenghtB, double lenghtC)
        {
            //равносторнний
            if (lenghtA == lenghtB && lenghtB == lenghtC)
            {
                Triangle equilateralTriangle = new EquilateralTriangle(lenghtA, lenghtB, lenghtC);
                return equilateralTriangle;
            }
            //равнобедренный
            else if (lenghtA == lenghtB || lenghtA == lenghtC || lenghtB == lenghtC)
            {
                Triangle isoscelesTriangle = new IsocelesTriangle(lenghtA, lenghtB, lenghtC);
                return isoscelesTriangle;
            }
            //прямоугольный
            else if (Math.Pow(lenghtC, 2) == Math.Pow(lenghtA, 2) + Math.Pow(lenghtB, 2))
            {
                Triangle rightTriangle = new RightTriangle(lenghtA, lenghtB, lenghtC);
                return rightTriangle;
            }
            //разносторонний
            else
            {
                Triangle scaleneTriangle = new ScaleneTriangle(lenghtA, lenghtB, lenghtC);
                return scaleneTriangle;
            }
        }
        public Rectangle CreateRectangle(double x, double y)
        {
            if (x == y)
            {
                return new Square(x);
            }
            else
                return new Rectangle(x, y);
        }
    }
}
