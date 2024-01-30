/*
Реализовать полную структуру классов и их взаимосвязь продумать самостоятельно. 
- Исходные данные: база (массив) из n товаров задать непосредственно в коде (захардкодить);
- Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, а также определить,
соответствует ли она сроку годности на текущую дату;

Создать производные классы:
- Продукт (название, цена, дата производства, срок годности),
- Партия (название, цена, количество шт, дата производства, срок годности),
Комплект (названия, цена, перечень продуктов) со своими методами вывода информации на экран, и определения соответствия сроку годности.

Создать базу (массив) из n товаров, вывести полную информацию из базы на экран,
а также организовать поиск просроченного товара (на момент текущей даты).
*/

using Task2;

public class Program
{
    public static void Main()
    {
        Product[] products = new Product[4];
        products[0] = new Product("Хлеб",45,new DateTime(2024,01,15),new TimeSpan(7,0,0,0));
        products[1] = new Product("Пряники",70,new DateTime(2024,01,25),new TimeSpan(15,0,0,0));
        products[2] = new Product("Молоко",80,new DateTime(2024,01,28),new TimeSpan(3,0,0,0));
        products[3] = new Product("Доширак",60,new DateTime(2024,01,01),new TimeSpan(365,0,0,0));

        foreach (Product p in products)
        {
            p.GetInfo();
            p.SrokGodnosty(DateTime.Now);
            Console.WriteLine();
        }

        Party[] parties = new Party[2];
        parties[0] = new Party("Хлеб", 45, new DateTime(2024, 01, 15), new TimeSpan(7, 0, 0, 0), 15);
        parties[1] = new Party("Доширак", 45, new DateTime(2024, 01, 15), new TimeSpan(20, 0, 0, 0), 100);

        foreach (Party p in parties)
        {
            p.GetInfo();
            p.SrokGodnosty(DateTime.Now);
            Console.WriteLine();
        }

        ProductBase[] productBases = new ProductBase[2];
        productBases[0] = new Complect("Студенческий", new List<Product> { products[0], products[3] });
        Console.WriteLine();
        productBases[0].GetInfo();
        productBases[0].SrokGodnosty(DateTime.Now);
    }
}