/*
Напишите программу, используя ArrayList, чтобы хранить информацию о книгах в библиотеке. 
Ваша программа должна предоставлять следующие функциональности:
Добавление книги: Пользователь может вводить информацию о новой книге, включая название, автора и год издания. Эта информация должна быть добавлена в ArrayList.
Отображение списка книг: Пользователь может просматривать список всех книг в библиотеке, включая название, автора и год издания.
Поиск книги по автору: Пользователь может ввести имя автора, и программа должна отобразить список книг этого автора.
Удаление книги: Пользователь может выбрать книгу из списка и удалить ее из библиотеки.
Выход из программы: Пользователь может завершить программу.
*/
using System.Collections;
using Task1;
internal class Program
{
    private static void Main()
    {
        ArrayList Book = new ArrayList();
        int command;
        while (true)
        {
            Console.WriteLine(@"Библиотека
1. Добавление книги
2. Отображение списка книг
3. Поиск книги по автору
4. Удаление книги
5. Выход из программы");
            Console.WriteLine();
            Console.WriteLine("Выберите необходимый пункт меню:");
            command = Convert.ToInt32(Console.ReadLine());
            switch (command)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Добавление книги");
                    Console.WriteLine("Введите название книги");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите автора книги");
                    string author = Console.ReadLine();
                    Console.WriteLine("Введите год издания книги");
                    int year = Convert.ToInt32(Console.ReadLine());

                    Book book = new Book(name, author, year);
                    Book.Add(book);
                    Console.WriteLine("Успешно добавлена книга");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Отображение списка книг");
                    if (Book.Count == 0)
                    {
                        Console.WriteLine("Книг нет");
                    }
                    else
                    {
                        Console.WriteLine("Список книг");
                        foreach (Book i in Book)
                        {
                            i.ShowInformation();
                        }
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Поиск книги по автору");
                    Console.WriteLine();
                    Console.WriteLine("Введите автора");
                    string searchAythor = Console.ReadLine();

                    foreach (Book i in Book)
                    {
                        if (i.author == searchAythor)
                        {
                            i.ShowInformation();
                        }
                        else Console.WriteLine("По данному автору книга не найдена");
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Удаление книги");
                    Console.WriteLine("Введите название книги, которую необходимо удалить");
                    string nameBookDelete = Console.ReadLine();

                    foreach (Book i in Book)
                    {
                        if (i.name == nameBookDelete)
                        {
                            Book.Remove(i);
                            Console.WriteLine("Книга была удалена");
                            break;
                        }
                        else Console.WriteLine("По данному названию книга не найдена"); ;
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Выход из программы");
                    return;
                default:
                    Console.WriteLine("Неверная команда");
                    break;
            }
        }
    }
}
