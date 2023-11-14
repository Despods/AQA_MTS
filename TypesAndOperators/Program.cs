// See https://aka.ms/new-console-template for more information

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

    // Решение нашей задачи
    // Подготовка данных
    bool isWhiteBreadFresh = true;
    ushort whiteBreadPrice = 150;
    ushort butterPrice = 230;
    ushort milkPrice = 170;
    float milFatPercentage = 1.2f;

    Console.WriteLine("Введите ваше имя:");
    string name = Console.ReadLine();
    Console.WriteLine($"Ваше имя: {name}");
    Console.WriteLine("Введите ваш возраст:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Ваш возраст: {age}");


}