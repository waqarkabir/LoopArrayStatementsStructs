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
            int bookIndex = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1) Enter a new book 2) List all books 3) Delete a book 4) Terminate Program");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        #region Book Create
                        Console.Clear();
                        Book book = new Book();
                        Console.WriteLine("Enter book name");
                        book.title = Console.ReadLine();

                        Console.WriteLine("Enter book author");
                        book.author = Console.ReadLine();
                        book.EnteredOn = DateTime.Now;

                        books[bookIndex] = book;
                        Console.WriteLine($"Book title is {book.title}, author is {book.author} that is entered on {book.EnteredOn}");
                        Console.WriteLine($"New book id is {bookIndex}");
                        bookIndex = bookIndex + 1;
                        #endregion
                        break;
                    case "2":
                        #region Book List
                        Console.Clear();
                        Console.WriteLine("List of books");
                        //if (bookindex>=0)
                        //{
                            for (int i = 0; i < bookIndex; i++)
                            {
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine($"Book title is {books[i].title}, author is {books[i].author} that is entered on {books[i].EnteredOn}");
                                Console.WriteLine("----------------------------------");
                            }
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Library is Empty");
                        //}
                        Console.ReadLine();
                        #endregion
                        break;
                    case "3":
                        #region Book Delete
                        Console.Clear();
                        Console.WriteLine("Enter a book to delete");
                        string searchString = Console.ReadLine();
                        searchString = searchString.Trim();
                        for (int i = 0; i < bookIndex; i++)
                        {
                            if (books[i].title.Equals(searchString))
                            {
                                Console.WriteLine($"'{books[i].title}' is deleted");
                                books[i].title = "";
                                books[i].author = "";
                                books[i].EnteredOn = DateTime.Now;
                                Console.ReadKey();
                            }
                        }
                        #endregion
                        break;
                    case "4":
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
