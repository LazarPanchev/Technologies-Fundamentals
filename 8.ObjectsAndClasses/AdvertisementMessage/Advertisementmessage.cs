using System;
using System.Linq;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main()
        {
            string[] phrases = {"Excellent product.","Such a great product.","I always use that product.","Best product of its category.",
                "Exceptional product.","I can’t live without this product." };
            string[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int num = int.Parse(Console.ReadLine());
            Random rn = new Random();
            for (int i = 0; i < num; i++)
            {
                int indexPhrases = rn.Next(0, phrases.Length);
                int indexEvents = rn.Next(0, events.Length);
                int indexAuthors = rn.Next(0, authors.Length);
                int indexCities = rn.Next(0, cities.Length);
                Console.WriteLine($"{phrases[indexPhrases]} {events[indexEvents]} {authors[indexAuthors]} – {cities[indexCities]}");
            }
        }
    }
}



