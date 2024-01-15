using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TransportDepo
    {
        public void TransportTypePrint(Transport transport)
        {
            string transportType = transport.GetTransportType();
            Console.WriteLine($"Тип транспорта: {transportType}");
        }
    }
}
