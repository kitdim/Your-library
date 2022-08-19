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

                if (Console.ReadKey().KeyChar == 'й') { Console.Clear(); break; }
                Console.Clear();
            }

            Console.WriteLine("Список книг:");
            foreach (var item in myBooks)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static Book InsertBook()
        {
            var book = new Book();

            Console.WriteLine("Процесс добавления книги:");
            Console.Write("Автор:"); 
            book.Autor = Console.ReadLine();
            Console.Write("Жанр:");
            book.Genre = Console.ReadLine();
            Console.Write("Название:");
            book.BookTitle = Console.ReadLine();

            Console.Write("Количество страниц:");
            if (!int.TryParse(Console.ReadLine(), out int page))
            {
                Console.WriteLine("Количество страниц введено не верно");
                book.Pages = 0;
            }
            else 
                book.Pages = page;
            return book;
        }
    }
}