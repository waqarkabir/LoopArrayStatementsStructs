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
            string searchString;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1) Enter a new book 2) List all books 3) Search a book 4) Delete a book 5) Terminate Program");
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
                        Console.WriteLine($"Book title is {book.title} with id {bookIndex + 1}, author is {book.author} that is entered on {book.EnteredOn}");
                        bookIndex = bookIndex + 1;
                        Console.WriteLine("Enter any key for main menu");
                        Console.ReadKey();
                        #endregion
                        break;
                    case "2":
                        #region Book List
                        Console.Clear();
                        Console.WriteLine("List of books");
                        if (bookIndex != 0)
                        {
                            for (int i = 0; i < bookIndex; i++)
                            {
                                Console.WriteLine("----------------------------------");
                                Console.WriteLine($"Book title is {books[i].title} with id {i + 1}, author is {books[i].author} that is entered on {books[i].EnteredOn}");
                                Console.WriteLine("----------------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Library is Empty");
                        }
                        Console.WriteLine("Enter any key for main menu");
                        Console.ReadKey();
                        #endregion
                        break;
                    case "3":
                        #region Book Search
                        Console.Clear();
                        Console.WriteLine("Enter title of Book to search");
                        searchString = Console.ReadLine();
                        searchString = searchString.Trim();
                        var searchIndex = -1;
                        for (int i = 0; i < bookIndex; i++)
                        {
                            if (books[i].title.Equals(searchString))
                            {
                                searchIndex = i;
                                break;
                            }


                        }
                        if (searchIndex > -1)
                        {
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine($"Book title is {books[searchIndex].title} with id {searchIndex + 1}, author is {books[searchIndex].author} that is entered on {books[searchIndex].EnteredOn}");
                            Console.WriteLine("----------------------------------");
                        }
                        else
                        {
                            Console.WriteLine($"Could not get the book for id {searchString}");
                        }
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();



                        #endregion
                        break;
                    case "4":
                        #region Book Delete
                        Console.Clear();
                        Console.WriteLine("Enter a book to delete");
                        searchString = Console.ReadLine();
                        searchString = searchString.Trim();
                        for (int i = 0; i < bookIndex; i++)
                        {
                            if (books[i].title.ToUpper().Equals(searchString.ToUpper()))
                            {
                                Console.WriteLine($"'{books[i].title}' is deleted");
                                for (int j = i; j < bookIndex-1; j++)
                                {
                                    books[j] = books[i + 1];
                                }
                            }
                        }
                        Book[] newBookArray = new Book[books.Length];
                        Array.Copy(books, newBookArray, bookIndex - 1);
                        books = newBookArray;
                        bookIndex--;


                        Console.WriteLine("Enter any key for main menu");
                        Console.ReadKey();
                        #endregion
                        break;
                    case "5":
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
