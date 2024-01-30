using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public  class Party:Product
    {
        //(название, цена, количество шт, дата производства, срок годности)
        public int count { get; set; }

        public Party(string productName, double productPrice, DateTime productDate, TimeSpan srokGodnosty, int count):base( productName,  productPrice,  productDate,  srokGodnosty)
        {
            this.count = count;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Партия продукта: {productName} Размер партии: {count} шт Цена: {productPrice} Дата производства: {productDate.ToShortDateString()} Срок годности: {srokGodnosty.TotalDays} дней");
        }
    }
}
