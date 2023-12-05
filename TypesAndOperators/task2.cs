public class Task2
{
    static void Main()
    {
        /*
         Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
         Welcome to the TMS lessons.
         Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". 
         Не забывайте о пробелах после каждого слова
        */

        string startWord = "Welcome to the TMS lessons.";//инициализируем исходный текст
        Console.WriteLine("Исходный текст: " + startWord);

        string[] words = startWord.Split(' ');//разделили текст на массив слов сплитом

        Console.WriteLine("Массив слов из исходного текста");

        foreach (string word in words)//бежим по массиву строк и выводим каждое слово
        {
            Console.Write($"'{word}' ");
        }
        Console.WriteLine();

        string finalText = String.Join("\" \"", words);//сделаем конкатенацию массива с разделителем (" ")
        finalText = finalText.Insert(0, "\"");//добавим недостающую " в начале строки
        finalText = finalText.Insert(finalText.Length, "\"");//добавим недостающую " в конце строки

        Console.WriteLine("Получившийся текст после объединения массива в строку: " + finalText);
    }
}