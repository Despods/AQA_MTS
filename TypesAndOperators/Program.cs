// See https://aka.ms/new-console-template for more information

using System.Numerics;
{
    //Это сообщение будет выведено на экран
    /*
    Console.WriteLine("Hello, World!");
    {
        Console.WriteLine("It's a nice day!");
    }
    */
    /*
    const string COMPANYNAME = "MTS";
    string name;
    name = "Zhdak";

    Console.WriteLine("It's a nice day");
    float d1 = 0.243f;
    */


    /*
    //Console.WriteLine("Введите ваше имя:");
    //string name = Console.ReadLine();
    //Console.WriteLine($"Ваше имя: {name}");
    //Console.WriteLine("Введите ваш возраст:");
    //int age = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine($"Ваш возраст: {age}");
    */
    /*
        // Решение нашей задачи
        // Подготовка данных
        bool isWhiteBreadFresh = true;
        ushort whiteBreadPrice = 150;
        ushort butterPrice = 230;
        ushort milkPrice = 170;
        float milFatPercentage = 1.2f;
        ushort icecreamPrice = 350;
        Console.Write("Введите начальный баланс: ");
        string? sumString = Console.ReadLine();
        short sum = Convert.ToInt16(sumString);

        if (sum > 0)
        {
            if (isWhiteBreadFresh)
            {
                if (sum >= whiteBreadPrice)
                {
                    sum -= (short)whiteBreadPrice;
                    Console.WriteLine($"Куплен свежий батон за {whiteBreadPrice} рублей");
                }
                else
                {
                    Console.WriteLine("На батон денег нет :(");
                }

            }
            else
            {
                Console.WriteLine("Батон не свежий");
            }

            sum += (short)butterPrice;

            if (milFatPercentage == 1.2f)
            {
                sum -= (short)milkPrice;
            }

            if (sum >= icecreamPrice)
            {
                sum -= (short)icecreamPrice;
            }

            Console.WriteLine($"Остаток суммы: {sum}");
        }
        else
        {
            Console.WriteLine("Деняк не дали :(");
        }
    */
    /*
    int x = 10;
    int y = 20;
    int z;
    if (x < y)
    {
        z = y + x;
    }
    else
    {
        z = x - y;
    }

    var z1 = x < y ? (x + y) : (x - y);
    Console.WriteLine(z);
    Console.WriteLine(z1);
    */
    /*
    int x = 1;
    switch (x)
    {
        case 1:
            Console.WriteLine("1");
            break;
        case 2:
            Console.WriteLine("2");
            break;
       default:
            Console.WriteLine("Отрицательно");
            break;
    }
    */
    string name = "Tom";
    switch (name)
    {
        case "Alex":
            Console.WriteLine("Alex");
            break;
        case "Tom":
            Console.WriteLine("Tom");
            break;
    }

    int DoOperation(int x)

    {
        switch (x)
        {
            case 1:
                return 1;
            case 2:
                return 2;
            default: 
                return 0;

        }
    }
    Console.WriteLine(DoOperation(2));

}



