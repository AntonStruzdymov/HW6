using HW6Library;
using Extensions;
Book book1 = new Book("Гордость и предубеждение", "Наша библиотека", 426);
Book book2 = new Book("1984", "Наша библиотека", 325);
Book book3 = new Book("Великий Гэтсби", "Наша библиотека", 235);
Book book4 = new Book("Хоббит", "Наша библиотека", 213);
Book book5 = new Book("Гроздья гнева", "Наша библиотека", 447);
Library Library = new Library();
Library.AddToLibrary(book1);
Library.AddToLibrary(book2);
Library.AddToLibrary(book3);
Library.AddToLibrary(book4);
Library.AddToLibrary(book5);
Console.WriteLine("Введите название книги");
string? bookname = Console.ReadLine();
Library.BookInfoConsole(bookname);
Console.WriteLine("Введите индекс книги");
int id = int.Parse(Console.ReadLine());
Library.BookInfoIndex(id);

Library.TheThickestBook();

int[] array = new int[] { 4, 6, 8, 23, 12, 56, 53, 67, 21, 52, 17, 97, 123, 54 };
array.BubbleMax();
array.BubbleMin();
Console.WriteLine();
