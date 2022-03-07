namespace HW6Library
{
    public class Book
    {
        private string bookName { get; set; }
        private string libraryName { get; set; }
        private int numberOfPages { get; set; }
        public Book(string bookName, string libraryName, int numberOfPages)
        {
            this.bookName = bookName;
            this.libraryName = libraryName;
            this.numberOfPages = numberOfPages;
        }
        public void BookInfo()
        {
            Console.WriteLine($"Название книги {bookName}, Библиотека: {libraryName}, количество страниц {numberOfPages}");
        }
        public bool isMatches(string name)
        {
            if (name == bookName)
            {
                return true;
            }
            return false;
        }
        public int Pages(Book book)
        {
            return numberOfPages;
        }
    }
}