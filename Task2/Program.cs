/*
Напишите обобщенный класс, который может хранить в массиве объекты любого типа. 
Также, данный класс должен иметь методы для добавления данных в массив, удаления из массива, получения элемента из массива по индексу и метод, возвращающий длину массива.
Для упрощения работы можно пересоздавать массив при каждой операции добавления и удаления
*/
using Task2;

internal class Program
{
    public static void Main(string[] args)
    {
        MyArray<int> intArrays = new MyArray<int>();
        intArrays.Add(1);
        intArrays.Add(5);
        intArrays.Add(2);

        Console.WriteLine("Массив");
        intArrays.PrintInfo();

        Console.WriteLine("Значение по индексу 1");
        Console.WriteLine(intArrays.GetIndex(1));

        Console.WriteLine("Удаляем значение");
        intArrays.Remove(2);
        intArrays.PrintInfo();

        Console.WriteLine("Длина массива");
        Console.WriteLine(intArrays.GetLenght());
    }
}