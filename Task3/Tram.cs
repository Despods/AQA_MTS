using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Tram : Transport
    {
        public Tram()
        {
        }
        public Tram(string destination, string departureTime, int countSeats, int number)
        {
            this.destination = destination;
            this.departureTime = departureTime;
            this.countSeats = countSeats;
            this.number = number;
        }
        public override string GetTransportType()
        {
            return "This is Tram";
        }
    }
}
