using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class EquilateralTriangle:Triangle
    {
        public EquilateralTriangle(double lenghtA, double lenghtB, double lenghtC) : base(lenghtA, lenghtB, lenghtC)
        {
        }
        //площадь посчитаем в родительском классе по формуле герона
    }
}
