using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Transport
    {
        public string destination { get; set; }
        public string departureTime { get; set; }
        public int countSeats { get; set; }
        public int number { get; set; }

        public abstract string GetTransportType();//обязательно должен быть реализован в наследниках

        public void TransportInfo()//нельзя переопределить
        {
            Console.WriteLine("Номер: {0}, Направление: {1}, Время отправления: {2}, Количество мест: {3}", number, destination, departureTime, countSeats);
        }
    }
}
