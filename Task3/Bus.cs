using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Bus : Transport
    {
        public Bus()
        {
        }
        public Bus(string destination, string departureTime, int countSeats, int number)
        {
            this.destination = destination;
            this.departureTime = departureTime;
            this.countSeats = countSeats;
            this.number = number;
        }

        public override string GetTransportType()
        {
            return "This is Bus";
        }
    }
}
