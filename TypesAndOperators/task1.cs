public class Task1
{
    static void Main1()
    {
        /*
        Заменить в строке все вхождения 'test' на 'testing'. 
        Удалить из текста все символы, являющиеся цифрами.
        */

        string text = "test TEST TeSt tested test1234 dotest";//инициализируем переменную

        Console.WriteLine(text);//выведем исходную переменную

        string replacedText = text.Replace("test", "testing");//меняем все test на testing

        Console.WriteLine(replacedText);

        string removedNumber = "";//инициализируем переменную, в которую положим исходный текст без цифр
        foreach (char d in replacedText)//бежим по массиву, если символ равен числу - меняем его на пустое символ. используя метод символа IsDigit
        {
            if (Char.IsDigit(d))
                removedNumber += "";
            else
                removedNumber += d;
        }

        Console.WriteLine(removedNumber);
    }
}