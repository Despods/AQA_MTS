using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class ScaleneTriangle:Triangle
    {
        public ScaleneTriangle(double lenghtA, double lenghtB, double lenghtC) : base(lenghtA, lenghtB, lenghtC)
        {
        }

        // метод расчета площади разностороннего треугольника
        public override double getSquare()
        {
            double square = (Math.Pow(lenghtA, 2) * Math.Sqrt(3)) / 4;
            return square;
        }
    }
}
