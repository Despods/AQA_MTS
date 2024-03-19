using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomeWork
{
    internal class Task2
    {
        //private Clients clients = new Clients();
        public void Run()
        {
            List<Clients> clients = new List<Clients>()
        {
            new Clients(2022,11,11),
            new Clients(2023,5,14),
            new Clients(2024,3,10),
            new Clients(2021,7,19),
            new Clients(2022,9,22),
            new Clients(2020,12,12),
            new Clients(2021,1,10)
        };

            var minDura = clients.Min(client => client.Duration);
            var result = clients.Where(client => client.Duration == minDura).Select(client =>
                new
                {
                    client.Duration,
                    client.Year,
                    client.Month,
                    client.Id
                }).Last();
            Console.WriteLine($"Минимальная продолжительность - {result.Duration}, в {result.Year} году {result.Month} месяце, у абонента с ид {result.Id}");
        }
    }
}
