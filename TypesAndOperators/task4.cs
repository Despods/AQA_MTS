public class Task4
{
    public static void Main1()
    {
        /*
		Создайте 2 массива из 5 чисел.
		Выведите массивы на консоль в двух отдельных строках.
		Посчитайте среднее арифметическое элементов каждого массива и сообщите, 
		для какого из массивов это значение оказалось больше 
		(либо сообщите, что их средние арифметические равны).
		*/
        int[] arrays1 = new int[5];
        int[] arrays2 = new int[5];

        //сравниваем средее арифметическое массивовй и выводим результат
        if (averageArrays(arrays1) == averageArrays(arrays2))
        {
            Console.WriteLine("Среднее арифметическое двух массивов равно");
        }
        else if (averageArrays(arrays1) > averageArrays(arrays2))
        {
            Console.WriteLine("Среднее арифметическое первого массива больше чем второго");
        }
        else
        {
            Console.WriteLine("Среднее арифметическое второго массива больше чем первого");

        }

        static void insertArray(int[] arrays) //метод для заполнения массива рандом значениями
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i] = new Random().Next(-50, 50);
            }
        }

        static void printArray(int[] arrays)//метод для вывода массива в консоль
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.Write($"{arrays[i]} ");
            }
            Console.WriteLine();
        }

        static int averageArrays(int[] arrays)//метод для подсчета среднего арифметического значения массива
        {
            int summ = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                summ += arrays[i];
            }
            int averageSumm = summ / arrays.Length;
            return averageSumm;
        }
        //заполняем массивы
        insertArray(arrays1);
        insertArray(arrays2);
        //выводим массивы
        printArray(arrays1);
        printArray(arrays2);
        //выводим среднее арифметическое значение массивов
        Console.WriteLine($"Среднее арифметическое первого массива: {averageArrays(arrays1)}");
        Console.WriteLine($"Среднее арифметическое второго массива: {averageArrays(arrays2)}");
    }
}
