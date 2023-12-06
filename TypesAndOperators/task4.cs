public class Task4
{
    static void Main1()
    {
        /*
        Дана строка: “Плохой день.”
        Необходимо с помощью метода substring удалить слово "плохой". 
        После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
        Заменить последний "!" на "?"
        */

        string startWord = "Плохой день.";//инициализируем изначальную строку

        Console.WriteLine($"Изначальный текст: {startWord}");

        string deletedWord = "Плохой";//инициализируем слово, которое надо удалить
        int deletedWordLenght = deletedWord.Length;//получаем его длинну

        string modifiedWord = startWord.Substring(deletedWordLenght + 1);//удаляем слово, +1 чтобы удалить пробел

        Console.WriteLine($"Строка после удаления слова: {modifiedWord}");

        string addWord = modifiedWord.Insert(0, "Хороший ");//вставляем слово хороший с 0 индекса
        addWord = addWord.Insert(addWord.Length - 1, "!!!!!!!!!");//вставляем знаки с длинны слова - 1, это будет индекс перед точкой

        Console.WriteLine($"Провели инсерт и реплейс: {addWord}");

        string finalWord = addWord.Remove(addWord.LastIndexOf("!"), 1);//удаляем последний !, интересно надо ли сохранять точку или ее тоже удалять?
        finalWord = finalWord.Insert(finalWord.Length - 1, "?");//вставляем знак вопроса в конец строки перед точкой

        Console.WriteLine($"Финальная строка: {finalWord}");




    }
}

