using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace Your_library
{
    public class Program
    {
        static void Main()
        {
            var myBooks = new List<Book>();

            while (true)
            {
                myBooks.Add(InsertBook());
                Console.WriteLine("Успешно!\n" +
                                  "Для выхода нажми 'q'");

                if (Console.ReadKey().KeyChar.ToString().ToLower() == "q")
                {
                    Console.Clear(); break;
                }
                Console.Clear();
            }
            var jsBook = new DataContractJsonSerializer(typeof(List<Book>));
            using (var file = new FileStream("mybooks.json", FileMode.OpenOrCreate))
            {
                jsBook.WriteObject(file,myBooks);
            }

            Console.WriteLine("Список книг:");
            using (var file = new FileStream("mybooks.json", FileMode.OpenOrCreate))
            {
                var books = jsBook.ReadObject(file) as List<Book>;
                if (books != null)
                {
                    foreach (var book in books)
                    {
                        Console.WriteLine(book);
                    }
                }
            }
            Console.ReadKey();
        }
        private static Book InsertBook()
        {
            Console.WriteLine("Процесс добавления книги:");
            Console.Write("Автор:"); 
            var autor = Console.ReadLine();

            Console.Write("Жанр:");
            var genre = Console.ReadLine();

            Console.Write("Название:");
            var title = Console.ReadLine();
            var page = 0;

            Console.Write("Количество страниц:");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Количество страниц введено не верно");
                page = 0;
            }
            else 
                page = number;

            var mybook = new Book(genre,title,autor,page);
            return mybook;
        }
    }
}