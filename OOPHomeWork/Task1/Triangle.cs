using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Triangle : Figure
    {
        public double lenghtA;
        public double lenghtB;
        public double lenghtC;

        public Triangle(double lenghtA, double lenghtB, double lenghtC)
        {
            this.lenghtA = lenghtA;
            this.lenghtB = lenghtB;
            this.lenghtC = lenghtC;
        }

        public override double getSquare()
        {
            double temp = (lenghtA + lenghtB + lenghtC) / 2;
            double square = Math.Sqrt(temp * (temp - lenghtA) * (temp - lenghtB) * (temp - lenghtC));
            return square;
        }
    }
}
