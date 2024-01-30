using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public  class Complect:ProductBase
    {
        //(названия, цена, перечень продуктов)
        public string nameComplect;
        public List<Product> Products {  get; set; }
        public Complect(string nameComplect, List<Product> products)
        {
            this.nameComplect = nameComplect;
            Products = products;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Комплект продуктов");
            foreach (Product product in Products)
            {
                product.GetInfo();
            }
        }
        public override void SrokGodnosty(DateTime now)
        {
            foreach (Product product in Products)
            {
                product.SrokGodnosty(now);
            }
        }
    }
}
