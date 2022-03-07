using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW6Library;

namespace Extensions
{
    public static class LibraryExtension
    {
        public static void TheThickestBook(this Library library)
        {
            Console.WriteLine("Книга с наибольшим количеством страниц: ");
            library.WhoIsYourDaddy();
        }
    }
}
