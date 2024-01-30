using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public  class Product:ProductBase
    {
        //(название, цена, дата производства, срок годности)
        public string productName { get; set; }
        public double productPrice { get; set; }
        public DateTime productDate { get; set; }
        public TimeSpan srokGodnosty { get; set; }

        public Product(string productName, double productPrice, DateTime productDate, TimeSpan srokGodnosty)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productDate = productDate;
            this.srokGodnosty = srokGodnosty;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Продукт: {productName} Цена: {productPrice} Дата производства: {productDate.ToShortDateString()} Срок годности: {srokGodnosty.TotalDays} дней");
        }
        public override void SrokGodnosty(DateTime now)
        {
            if (now < productDate.Add(srokGodnosty))
                Console.WriteLine("Товар годен к употреблению");
            else
                Console.WriteLine("Товар нельзя употреблять");
        }
    }
}
