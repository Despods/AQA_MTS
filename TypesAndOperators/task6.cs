public class Task6
{
    public static void Main1()
    {
        /*
         Создайте массив и заполните массив.
         Выведите массив на экран в строку.
         Замените каждый элемент с нечётным индексом на ноль.
         Cнова выведете массив на экран на отдельной строке.
        */
        int[] arrays = new int[new Random().Next(0, 11)];//создаем массив размерностью от 0 до 10
        for (int i = 0; i < arrays.Length; i++)//заполняем значениями от 1 до 9
        {
            arrays[i] = new Random().Next(1, 10);
        }
        PrintArray(arrays);//выводим массив в консоль

        for (int i = 1; i < arrays.Length; i += 2)//бежим по массиву по нечетным индексам и заменяем их на 0
        {
            arrays[i] = 0;
        }
        PrintArray(arrays);//выводим измененный массив в консоль
    }



    static void PrintArray(int[] arrays)//метод для вывода массива в консоль
    {
        for (int i = 0; i < arrays.Length; i++)
        {
            Console.Write($"{arrays[i]} ");
        }
        Console.WriteLine();
    }
}