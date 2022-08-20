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

                if (Console.ReadKey().KeyChar == 'q' || Console.ReadKey().KeyChar == 'й') { Console.Clear(); break; }
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
            //WriteBookToJson(mybook);
            return mybook;
        }

        //private async static void WriteBookToJson(Book book)
        //{
        //    using (FileStream fs = new FileStream("myliblary.json", FileMode.OpenOrCreate))
        //    {
        //        await JsonSerializer.SerializeAsync<Book>(fs, book);
        //        Console.WriteLine("Data has been saved to file");
        //    }

        //   // чтение данных
        //    using (FileStream fs = new FileStream("myliblary.json", FileMode.OpenOrCreate))
        //    {
        //        Book book1 = await JsonSerializer.DeserializeAsync<Book>(fs);
        //        Console.WriteLine(book1);
        //    }
        //}
    }
}