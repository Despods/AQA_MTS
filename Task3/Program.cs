/*
Коллекция содержит набор чисел в виде одной строки "1, 2, 3, 4, 4, 5". 
Избавиться от повторяющихся элементов в строке и вывести результат на экран.
*/
internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Изначальная коллекция");
        List<int> nums = new List<int> { 1, 2, 3, 4, 4, 5 };

        foreach (var item in nums)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
        Console.WriteLine("Модифицированная коллекция без дублей");
        HashSet<int> set = new HashSet<int>(nums);

        foreach (var item in set)
        {
            Console.Write($"{item} ");
        }
    }
}