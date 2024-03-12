/*
Напишите программу, используя Dictionary, чтобы управлять инвентарем товаров в магазине. 
Ваша программа должна предоставлять следующие функциональности:
Добавление товара: Каталог товаров генерируется на основании рандомных значений или инициализируется конкретными данными. Информация о новом товаре, включает уникальный идентификатор, название, цену и количество на складе.
Отображение списка товаров: Пользователь может просматривать список всех товаров в магазине, включая название, цену и количество на складе.
Поиск товара по идентификатору: Пользователь может ввести уникальный идентификатор товара, и программа должна отобразить информацию о товаре с этим идентификатором.
Обновление информации о товаре: Пользователь может выбрать товар из списка и обновить его цену или количество на складе.
Удаление товара: Пользователь может выбрать товар из списка и удалить его из инвентаря.
*/
using Task2;
internal class Program
{
    private static void Main()
    {
        Dictionary<int, Product> products = new Dictionary<int, Product>();
        int command;
        while (true)
        {
            Console.WriteLine(@"Магазин
1. Добавление товара
2. Отображение списка товаров
3. Поиск товара по идентификатору
4. Обновление информации о товаре
5. Удаление товара
6. Выход из программы");
            Console.WriteLine();
            Console.WriteLine("Выберите необходимый пункт меню:");
            command = Convert.ToInt32(Console.ReadLine());
            switch (command)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Добавление товара");
                    Console.WriteLine("Введите название товара");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите количество товара");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите ид товара");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите цену товара");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Product product = new Product(id, name, count, price);
                    products.Add(id, product);
                    Console.WriteLine("Товар добавлен в список");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Отображение списка товаров");
                    if (products.Count == 0)
                    {
                        Console.WriteLine("Товаров нет");
                    }
                    else
                    {
                        Console.WriteLine("Список товаров");
                        foreach (var i in products)
                        {
                            var item = i.Value;
                            item.ShowInformation();
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Поиск товара по идентификатору");
                    Console.WriteLine("Введите ИД товара для поиска:");
                    int searchId = Convert.ToInt32(Console.ReadLine());

                    if (products.ContainsKey(searchId))
                    {
                        Product product1 = products[searchId];
                        product1.ShowInformation();
                    }
                    else
                    {
                        Console.WriteLine("Товар не найден");
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Обновление информации о товаре");
                    Console.WriteLine("Введите ИД товара, который хотите изменить");
                    int idForChangeProduct = Convert.ToInt32(Console.ReadLine());
                    if (products.ContainsKey(idForChangeProduct))
                    {
                        Console.WriteLine("Введите новую цену товара:");
                        int newprice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите новое количество товара:");
                        int newquantity = Convert.ToInt32(Console.ReadLine());
                        Product newproduct = products[idForChangeProduct];
                        newproduct.price = newprice;
                        newproduct.count = newquantity;
                        products[idForChangeProduct] = newproduct;
                        Console.WriteLine("Товар обновлен");
                    }
                    else
                    {
                        Console.WriteLine("Товар не найден");
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Удаление товара");
                    Console.WriteLine("Введите ИД товара для удаления");
                    int idForDeleteProduct = Convert.ToInt32(Console.ReadLine());

                    if (products.ContainsKey(idForDeleteProduct))
                    {
                        products.Remove(idForDeleteProduct);
                        Console.WriteLine("Товар был удален");
                    }
                    else
                    {
                        Console.WriteLine("По данному товар не найден");
                    }
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Выход из программы");
                    return;
                default:
                    Console.WriteLine("Неверная команда");
                    break;
            }
        }
    }
}