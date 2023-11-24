public class ThirtdTask
{
    public static void Main1()
    {
        /*
        Напишите программу русско-английский переводчик.
        Программа знает 10 слов о погоде.
        Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
        Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
        */
        Console.WriteLine("Введите слово о погоде на русском, чтобы получить перевод на английский.");
        Console.WriteLine("Пока что я начинающий переводчик и знаю всего 10 слов");
        Console.WriteLine("Доступные слова для перевода: Солнце, Небо, Зима, Весна, Лето, Осень, Дождь, Снег, Холод, Тепло");
        string russianWord = Console.ReadLine(); //Получаем слово от пользователя

        russianWord = russianWord.ToLower(); //Переводим слово в нижний регистр для простоты поиска

        switch (russianWord) //ищем перевод слова введенного пользователем
        {
            case "солнце":
                Console.WriteLine("Перевод на английский: Sun");
                break;
            case "небо":
                Console.WriteLine("Перевод на английский: Sky");
                break;
            case "зима":
                Console.WriteLine("Перевод на английский: Winter");
                break;
            case "весна":
                Console.WriteLine("Перевод на английский: Spring");
                break;
            case "лето":
                Console.WriteLine("Перевод на английский: Summer");
                break;
            case "осень":
                Console.WriteLine("Перевод на английский: Autumn");
                break;
            case "дождь":
                Console.WriteLine("Перевод на английский: Rain");
                break;
            case "снег":
                Console.WriteLine("Перевод на английский: Snow");
                break;
            case "холод":
                Console.WriteLine("Перевод на английский: Cold");
                break;
            case "тепло":
                Console.WriteLine("Перевод на английский: Warm");
                break;
            default:
                Console.WriteLine("Я еще не знаю такого слова, но я обещаю его узнать и вернуться с ответом");
                break;
        }
    }
}
