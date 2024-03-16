using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork
{
    internal class Task2Delegate
    {
        public delegate double TaskTwoDelegate(double radius);

        public void Run()
        {
            double radius = 3;
            TaskTwoDelegate dlina = DlinaOkruzhnosti;
            TaskTwoDelegate ploshad = PloshadKruga;
            TaskTwoDelegate obem = ObemShara;

            Console.WriteLine($"Длина окружности с радиусом {radius} - {dlina(radius)}");
            Console.WriteLine($"Площадь круга с радиусом {radius} - {ploshad(radius)}");
            Console.WriteLine($"Объем шара с радиусом {radius} - {obem(radius)}");
        }

        private double DlinaOkruzhnosti(double radius)
        {
            double dlina = 2 * Math.PI * radius;
            return dlina;
        }
        private double PloshadKruga(double radius)
        {
            double ploshad = Math.PI * Math.Pow(radius,2);
            return ploshad;
        }
        private double ObemShara(double radius)
        {
            double obem = 4/3 * Math.PI * Math.Pow(radius, 3);
            return obem;
        }
    }
}
