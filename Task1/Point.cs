using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Point<T>
    {
        private T x;
        private T y;

        public T X { get { return this.x; } }
        public T Y { get { return this.y; } }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Координаты: X = {x}, Y = {y}.");
        }
    }
}
