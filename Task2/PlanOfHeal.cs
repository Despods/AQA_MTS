using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class PlanOfHeal
    {
        public int planOfHealCode;
        public PlanOfHeal(int planOfHealCode)
        {
            this.planOfHealCode = planOfHealCode;
        }
        public Doctor ChooseDoctor()
        {
            switch (planOfHealCode)
            {
                case 1: return new Surgeon();
                case 2: return new Dentist();
                default: return new Therapist();
            }
        }
    }
    
}
