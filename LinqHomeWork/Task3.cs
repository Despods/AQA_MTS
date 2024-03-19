using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomeWork
{
    internal class Task3
    {
        public void Run() 
        {
            List<string> strings = new List<string>() 
            { "BOB", "MARLEY", "SAM", "KATE", "YURKA", "MAX", "SAME", "ALEX" };

            Console.WriteLine("Изначальная коллекция");
            PrintHelper.Print(strings);

            var sortStrings =
                (from i in strings
                 orderby i descending
                 select i).OrderBy(i => i.Length);

            Console.WriteLine("Отсортированная коллекция");
            PrintHelper.Print(sortStrings);
        }
    }
}
