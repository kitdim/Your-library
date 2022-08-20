namespace Your_library
{
    class Book
    {
        private static int id = 1;

        public int Id { get; set; }
        public string Genre { get; set; }
        public string BookTitle { get; set; }
        public string Autor { get; set; }
        public int Pages { get; set; }
        

        public Book(string genre, string bookTitle, string autor, int page)
        {
            Genre = genre;
            BookTitle = bookTitle;
            Autor = autor;
            Pages = page;
            Id = id++;
        }
        public Book() { }

        public override string ToString()
        {
            return $"{Id}.Жанр:{Genre}|Название книги:{BookTitle}|Автор:{Autor}|Количество страниц:{Pages} стр.";
        }
    }
}
