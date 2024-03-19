using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomeWork
{
    internal class Task1
    {
        public void Run()
        {
            Console.WriteLine("Изначальная коллекция");
            var listNumbers = new List<int>() { -4, -4, -3, -2, -2, -1, 0, 1, 2, 1, 2, 3, 4, 5, 4, 5 };
            var resultNumbers = listNumbers.Where(number => Math.Abs(number) % 2 == 1).Distinct();
            PrintHelper.Print(resultNumbers);
        }
    }
}
