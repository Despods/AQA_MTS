using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Surgeon : Doctor
    {
        public override void Heal(string patientName)
        {
            Console.WriteLine($"{patientName} Тебя лечит хирург");
        }
    }
}
