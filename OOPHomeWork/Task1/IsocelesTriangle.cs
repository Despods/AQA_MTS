using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class IsocelesTriangle:Triangle
    {
        public IsocelesTriangle(double lenghtA, double lenghtB, double lenghtC) : base(lenghtA, lenghtB, lenghtC)
        {
        }

        // метод расчета площади равнобедренного треугольника
        public override double getSquare()
        {
            double side;
            double baseTriangle;
            if (lenghtA == lenghtB)
            {
                side = lenghtA;
                baseTriangle = lenghtC;
            }
            else if (lenghtB == lenghtC)
            {
                side = lenghtB;
                baseTriangle = lenghtA;
            }
            else
            {
                side = lenghtC;
                baseTriangle = lenghtB;
            }
            double square = (baseTriangle * Math.Sqrt(Math.Pow(side, 2) - (Math.Pow(baseTriangle, 2) / 4))/2);
            return square;
        }
    }
}
