using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle(double lenghtA, double lenghtB, double lenghtC) : base(lenghtA, lenghtB, lenghtC)
        {
        }

        // метод расчета площади прямоугольного треугольника
        public override double getSquare()
        {
            double temp1;
            double temp2;
            if (lenghtA < lenghtB)
            {
                temp1 = lenghtA;

                if (lenghtB < lenghtC)
                {
                    temp2 = lenghtB;
                }
                else
                {
                    temp2 = lenghtC;
                }
            }
            else
            {
                temp1 = lenghtB;
                if (lenghtA < lenghtC)
                {
                    temp2 = lenghtA;
                }
                else
                {
                    temp2 = lenghtC;
                }
            }
            double square = (temp1 * temp2)/2;
            return square;
        }
    }
}
