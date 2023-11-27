using System;

public class Task2
{
	public static void Main()
	{
		/*
		Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
		Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
		В результате должен быть новый массив без указанного числа.
		*/
		int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 2, 3, 2, 2 }; //создаем массив, который содержит 4 двойки
        foreach (int i in array1)//выводим изначальный массив в консоль
        {
			Console.Write($"{i} ");
        }
		Console.WriteLine();
        Console.WriteLine("Введите число, которое необходимо удалить из массива: ");
		int deleteNumber = Convert.ToInt32(Console.ReadLine()); //принимаем строку и делаем из нее число
        int array1Lenght = array1.Length;
        if (array1.Contains(deleteNumber))//если массив содержит число, которое нужно удалить, то бежим по массиму и считаем на сколько нам нужно уменьшить новый массив
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == deleteNumber)
                {
                    array1Lenght--; 
                }
            }
            int[] array2 = new int[array1Lenght];//создаем новый массив 2(длинной меньше чем 1, на количество совпадений значений)
            int tmp = 0;//временная переменная для подсчета индексов в новом массиве
            for (int i = 0; i < array1.Length; i++)//заполняем новый массив значениями старого, за исключением того, которое надо удалить
            {
                if (array1[i] != deleteNumber)
                {
                    array2[tmp] = array1[i];
                    tmp++;
                }
            }
            foreach (int i in array2)//выводим измененный массив в консоль
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Данное число {deleteNumber} не входит в массив");
        }


            
        
        






    }
}
