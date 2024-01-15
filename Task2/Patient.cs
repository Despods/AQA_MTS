using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Patient
    {
        public string name;
        public PlanOfHeal planOfHeal;

        public Patient(string name, PlanOfHeal planOfHeal)
        {
            this.name = name;
            this.planOfHeal = planOfHeal;
        }

        public void HealPatient()
        {
            Doctor doc = planOfHeal.ChooseDoctor();
            doc.Heal(name);
        }
    }
}
