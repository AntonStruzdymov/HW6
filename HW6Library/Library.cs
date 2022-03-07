using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6Library
{
    public class Library
    {
        private int count = 0;
        private int count2 = 0;
        private int pages = 0;
        private Book[] books = new Book[5]; 
        public void AddToLibrary(Book book)
        {
            books[count] = book;
            count++;
        }
        public void BookInfoIndex(int index)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (i == index)
                {
                    books[i].BookInfo();
                }
            }
        }
        public void BookInfoConsole(string name)
        {            
            foreach (Book book in books)
            {
                if (book.isMatches(name))
                {
                    book.BookInfo();
                    count2++;
                }         
                
            }
            if (count2 == 0)
            {
                Console.WriteLine("Такой книги у нас нет");
            }
        }
        public void WhoIsYourDaddy()
        {
            foreach (Book book in books)
            {
                if (book.Pages(book) > pages)
                {
                    pages = book.Pages(book);
                }
            }
            foreach (Book book in books)
            {
                if (pages == book.Pages(book))
                {
                    book.BookInfo();
                }
            }

        }
    }   
}
