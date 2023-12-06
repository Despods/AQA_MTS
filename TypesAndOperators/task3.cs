public class Task3
{
    static void Main1()
    {
        /*
        Дана строка: “teamwithsomeofexcersicesabcwanttomakeitbetter.”
        Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
        Результат вывести в консоль.
        */

        string startText = "teamwithsomeofexcersicesabcwanttomakeitbetter";//инициализируем изначальную переменную с текстом
        Console.WriteLine($"Изначальный текст: {startText}");

        string findText = "abc"; //переменная с искомым текстом

        int startIndex, endIndex;//переменные для отсчета индекса, где наше findText начинается и где заканчивается

        startIndex = startText.IndexOf(findText);//начальный индекс слова которое ищем
        endIndex = startIndex + findText.Length;//конечный индекс слова которое ищем = начальный индекс + длинна слова

        string firstPart = startText.Substring(0, startIndex);//обрезаем строку от начала до искомого слова
        string secondPart = startText.Substring(endIndex);//обрезаем строку от конца искомого слова до конца исходной строки
        string middlePart = startText.Substring(startIndex, findText.Length);//обрезаем строку от начала искомого слова до конца исходного текста

        Console.WriteLine($"Текст до искомых символов: {firstPart}");
        Console.WriteLine($"Текст после искомых символов: {secondPart}");
        Console.WriteLine($"Текст искомых символов: {middlePart}");

        //второй варианет решения
        Console.WriteLine("Решение через 2 вариант");

        string[] array = startText.Split("abc");//разделим исходный текст на 2 стринги через сплит используя искомое слово как разделитель
        //выведем получившиеся строки массива
        Console.WriteLine($"Первая часть текста до символов: {array[0]}");
        Console.WriteLine($"Вторая часть текста после символов: {array[1]}");
    }
}