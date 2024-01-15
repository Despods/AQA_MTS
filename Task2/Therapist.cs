using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Therapist : Doctor
    {
        public override void Heal(string patientName)
        {
            Console.WriteLine($"{patientName} тебя лечит терапевт");
        }
    }
}
