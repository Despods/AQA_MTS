using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomeWork
{
    internal class Clients
    {
        private static int ID = 0;
        public int Id;
        public int Year { get; set; }
        public int Month { get; set; }
        public int Duration { get; set; }

        public Clients(int Year, int Month, int Duration)
        {
            this.Id = ID++;
            this.Year = Year;
            this.Month = Month;
            this.Duration = Duration;
        }

        public Clients()
        {
        }
    }
}
