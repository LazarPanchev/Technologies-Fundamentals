using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace BookLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleasedData { get; set; }
        public string IsbnNumber { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, string publisher, DateTime releasedDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleasedData = releasedDate;
            IsbnNumber = isbn;
            Price = price;
        }
    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> BooksList { get; set; }

        public Library(string name, List<Book> bookList)
        {
            Name = name;
            BooksList = bookList;
        }
    }

    public class BookLibrary
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Library library = new Library("Svetlina", new List<Book>());
            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();
            for (int i = 0; i < num; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                Book currentBook = new Book(tokens[0], tokens[1], tokens[2], DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    tokens[4], decimal.Parse(tokens[5]));


                library.BooksList.Add(currentBook);

                if (!dict.ContainsKey(currentBook.Author))
                {
                    dict.Add(currentBook.Author, 0M);
                }

                dict[currentBook.Author] += currentBook.Price;
            }

            foreach (var pair in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string author = pair.Key;
                decimal totalPrice = pair.Value;
                Console.WriteLine($"{author} -> {totalPrice:F2}");
            }

        }
    }

}