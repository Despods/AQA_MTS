using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Rectangle : Figure
    {
        
        double x;
        double y;

       
        public Rectangle(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        
        public override double getSquare()
        {
            double square = x * y;
            return square;
        }
    }
}
