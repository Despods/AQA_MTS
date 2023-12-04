public class Task5
{
    public static void Main1()
    {
        /*
         Создайте массив из n случайных целых чисел и выведите его на экран.
         Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.
         Если n не удовлетворяет условию - выведите сообщение об этом. Если пользователь ввёл не подходящее число, то программа должна просить пользователя повторить ввод.
         Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.
        */
        Console.WriteLine("Введите размер массива: ");
        int arraySize = Convert.ToInt32(Console.ReadLine());//получаем от пользователя число для размера массива
        bool flag;//булевый флаг для отслеживания выполнения условия
        do
        {
            if (arraySize > 5 && arraySize < 10)
            {
                Console.WriteLine("Размер массива соответсвует допустимому");
                flag = true;
            }
            else
            {
                Console.WriteLine("Размер массива не соответсвует допустимому. Повторите ввод: ");
                arraySize = Convert.ToInt32(Console.ReadLine());//получаем от пользователя число для размера массива
                flag = false;
            }
        } while (!flag);

        int[] arrays = new int[arraySize];//создаем массив
        int counter = 0;//переменная для подсчета четных значений
        for (int i = 0; i < arrays.Length; i++)//заполняем значениями от 0 до 9
        {
            arrays[i] = new Random().Next(0, 10);
            counter = arrays[i] % 2 == 0 ? ++counter : counter;//краткий if через теранрый оператор для вычисления четного числе, если четкое, то couner +1
        }
        PrintArray(arrays);//выводим 1 массив

        if (counter > 0)//есть ли четные числа в массиве
        {
            int index = 0;//перемсенная для подсета индекса во 2 массиве
            int[] array2 = new int[counter];
            for (int i = 0; i < arrays.Length; i++)//бежим по массиву, если число четное добавляем его во 2 массив
            {
                if (arrays[i] % 2 == 0)
                {
                    array2[index] = arrays[i];
                    index++;
                }
            }
            PrintArray(array2);
        }
        else
            Console.WriteLine("В массиве нет четных чисел");
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