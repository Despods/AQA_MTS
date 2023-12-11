public class Task7
{
    public static void Main()
    {
        /*
        Создайте массив строк. Заполните его произвольными именами людей.
        Отсортируйте массив.
        Результат выведите на консоль.
        */

        string[] names = { "Наталья", "Иван", "Илья", "Александр", "Виталий", "Анастасия", "Илья", "Ян" };//создаем массив с именами
        Console.WriteLine("Изначальный массив");
        PrintArray(names);//выводим в консоль
        Array.Sort(names);//сортируем
        Console.WriteLine("Отсортированный массив");
        PrintArray(names);//выводим в консоль

    }
    static void PrintArray(string[] arrays)//метод для вывода массива в консоль
    {
        for (int i = 0; i < arrays.Length; i++)
        {
            Console.Write($"{arrays[i]} ");
        }
        Console.WriteLine();
    }
}




