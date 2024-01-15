/*
Создать класс, со следующими свойствами:
сlass Bus: Пункт назначения, Номер, Время отправления, Число мест
Определить get, set методы для этих свойств.

Создать класс с main методом, в котором будет объявлен объект класса Bus. Вывести все данные (значения полей) объекта в консоль.

Определить иерархию классов в предметной области: Парк общественного траспорта.
Определить иерархию различных видов общественного транспорта (например, Trolleybus, Tramcar и т.д. на подобие класса Bus выше.)
Определить в суперклассе (например, сlass Transport) метод, возвращающий тип транспорта (Electric, Rail, и т.п.). Переопределить этот метод в классах наследниках.
В классе с main методом создать массив объектов из различных видов транспорта. 
Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль. 
Запросить у пользователя время отправления и/или пункт назначения. 
Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные в консоль. 
Запросить у пользователя время отправления. Вывести в консоль список транспорта, отправляющегося после заданного времени.

** Определить метод в суперклассе (e.g. Transport), который нельзя будет переопределить в классах наследниках и запретить это переопределение.
** Создать класс TransportService. Определить внутри класса TransportService метод printTransportType, который будет принимать объект типа Transport как параметр. Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип транспорта и вывести эту информацию на консоль.
** В main вызвать метод printTransportType несколько раз, передавая ему как параметр объекты классов наследников (Bus, Trolleybus и т.д.)
*/

using Task3;

internal class Program
{
    static void Main(string[] args)
    {
        Transport[] transportArray = new Transport[5];
        transportArray[0] = new Bus("Екб","15:30", 20, 1);
        transportArray[1] = new Tram("Мск", "12:30", 40, 14);
        transportArray[2] = new Car("Спб", "19:30", 4, 6);
        transportArray[3] = new Car("Влг", "11:30", 7, 9);
        transportArray[4] = new Bus("KFC", "20:30", 25, 7);

        TransportDepo temp = new TransportDepo();

        Console.WriteLine("Доступный транспортЭ");

        foreach (var item in transportArray)
        {
            temp.TransportTypePrint(item);
        }

        Transport temps;//сортируем по возрастанию кол-ва мест

        for (int i = 0; i < transportArray.Length - 1; i++)
        {
            for (int j = i + 1; j < transportArray.Length; j++)
            {
                if (transportArray[i].countSeats > transportArray[j].countSeats)
                {
                    temps = transportArray[i];
                    transportArray[i] = transportArray[j];
                    transportArray[j] = temps;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Транспорт отсортированный по местам");

        foreach (var item in transportArray)
        {
            item.TransportInfo();
        }

        Console.WriteLine("Введите пункт назначения: ");//Ищем нужный маршрут
        string? selectDestination = Console.ReadLine();
        bool flag = false;

        foreach(var item in transportArray)
        {
            if (item.destination == selectDestination)
            {
                item.TransportInfo();
                flag = true;
                break;
            }
        }
        if (!flag) Console.WriteLine("Такого пункта назнначения нет");

        Console.WriteLine();

        Console.WriteLine("Введите время, после которого вы ходите уехать. Формат ввода (hh:mm)");//отберем маршруты после указанного времени
        string? departureTimeFind = Console.ReadLine();

        foreach (var item in transportArray)
        {
            if (TimeSpan.Parse(item.departureTime) > TimeSpan.Parse(departureTimeFind))
                item.TransportInfo();
        }

        Console.WriteLine();

        TransportDepo tps = new TransportDepo();
        tps.TransportTypePrint(new Bus());
        tps.TransportTypePrint(new Car());
        tps.TransportTypePrint(new Tram());
    }
}