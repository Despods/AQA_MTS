public class Task3
{
    public static void Main()
    {
        /*
		Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
		Для генерации случайного числа используйте метод Random() . 
		Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли.
		*/
        Console.WriteLine("Введите размер массива: ");
        int arraySize = Convert.ToInt32(Console.ReadLine());//принимаем на вход стринг от пользователя и делаем инт
        int[] arrays = new int[arraySize];//инициализируем массив

        Random random = new Random();

        for (int i = 0; i < arraySize; i++)//заполняем массив рандом значениями
        {
            arrays[i] = random.Next(-100, 100);
        }

        for (int i = 0; i < arraySize; i++)//выводим получившийся массив
        {
            Console.Write($"{arrays[i]} ");
        }
        Console.WriteLine();

        Array.Sort(arrays);//сортируем массим для простоты обработки

        for (int i = 0; i < arraySize; i++)//выводим получившийся массив
        {
            Console.Write($"{arrays[i]} ");
        }
        Console.WriteLine();

        Console.WriteLine($"Минимальное значение: {arrays[0]}");//берем первое значение по индексу, после сортировки оно самое минимальное

        Console.WriteLine($"Максимальное значение: {arrays[arrays.GetUpperBound(0)]}");//берем последнее значение массива, после сортировки оно самое большое, GetUpperBound вернет индекс

        if (arrays.Length % 2 != 0)//если остоток от деления на 2 не равен нулю, значит кол-во элементов в массиве нечетное, значит среднее значение 1, иначе 2

            Console.WriteLine($"Значение в середине массива: {arrays[arrays.GetUpperBound(0) / 2]}");
        else
        {
            Console.WriteLine($"1 Значение в середине массива: {arrays[arrays.GetUpperBound(0) / 2]}");
            Console.WriteLine($"2 Значение в середине массива: {arrays[arrays.GetUpperBound(0) / 2 + 1]}");
        }
    }
}
