namespace Task2
{
    public class Product
    {
        private int id;
        public string name;
        public int price;
        public int count;

        public Product(int id, string name, int price, int count)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Ид товара: {0}", id);
            Console.WriteLine("Название товара: {0}", name);
            Console.WriteLine("Стоисомть товара: {0}", price);
            Console.WriteLine("Кол-во на складе: {0}", count);
        }

    }
}
