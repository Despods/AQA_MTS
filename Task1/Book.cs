namespace Task1
{
    public class Book
    {
        public string name;
        public string author;
        public int yearPublication;

        public Book(string name, string author, int yearPublication)
        {
            this.name = name;
            this.author = author;
            this.yearPublication = yearPublication;
        }
        public void ShowInformation()
        {
            Console.WriteLine("Название книги: {0}", name);
            Console.WriteLine("Автор: {0}", author);
            Console.WriteLine("Год публикации: {0}", yearPublication);
        }
    }
}
