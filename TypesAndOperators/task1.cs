public class Task1
{
    static void Main1()
    {
        /*
		Создайте массив целых чисел. 
		Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет. 
		Пусть число для поиска задается с консоли.
		*/
        int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; //Создаем массив из 8 чисел
        Console.WriteLine("Введите число для поиска его в массиве: ");
        int numberFind = Convert.ToInt32(Console.ReadLine()); //считаваем строку и преобразовываем в инт

        if (array1.Contains(numberFind)) //Проверяем входит ли число в массив встроенным методом массива
        {
            Console.WriteLine($"Число '{numberFind}' входит в массив!");
        }
        else
        {
            Console.WriteLine($"Число '{numberFind}' не входит в массив!");
        }
    }
}
