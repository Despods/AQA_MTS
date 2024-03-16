using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomeWork
{
    internal class Task1Delegate
    {
        public delegate int TaskOneDelegate();

        public void Run()
        {
            TaskOneDelegate taskOneDelegate = new(RandomNumber);
            Console.WriteLine($"Число рандом от 0 до 5 - {taskOneDelegate()}");
        }

        private int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0,11);
        }
    }
}
