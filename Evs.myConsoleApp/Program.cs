using Entities;
using System;

namespace Evs.myConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book[] books = new Book[3];
            bool terminator = false;
            int bookindex = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1) Enter a new book 2) List all books 3) Delete a book");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Book book = new Book();
                        Console.WriteLine("Enter book name");
                        book.Title = Console.ReadLine();

                        Console.WriteLine("Enter book author");
                        book.author = Console.ReadLine();
                        book.EnteredOn = DateTime.Now;

                        books[bookindex] = book;
                        Console.WriteLine($"Book title is {book.Title}, author is {book.author} that is entered on {book.EnteredOn}");
                        Console.WriteLine($"New book id is {bookindex}");
                        bookindex = bookindex + 1;

                        break;
                    case "2":
                        Console.Clear();
                        if (bookindex>0)
                        {
                            for (int i = 0; i < books.Length; i++)
                            {
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine($"Book title is {books[i].Title}, author is {books[i].author} that is entered on {books[i].EnteredOn}");
                                Console.WriteLine("----------------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Library is Empty");
                        }

                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Program is terminating on request");
                        terminator = true;
                        break;
                    default:
                        Console.WriteLine("Program is terminating on invalid entry");
                        terminator = true;
                        break;
                }
            }
            while (!terminator);
        }
    }
}
