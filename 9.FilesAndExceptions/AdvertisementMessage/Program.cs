using System;
using System.IO;
using System.Linq;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {


            //string[] phrases =
            //{
            //     "Excellent product.", "Such a great product.", "I always use that product.",
            //    "Best product of its category.", "Exceptional product.","I can’t live without this product."
            //};
            //
            //string[] events =
            //{
            //    "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
            //     "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            //
            //};
            //
            //string[] authors =
            //{
            //    "Diana ", "Petya ", "Stella ", "Elena ", "Katya ", "Iva ", "Annie ", "Eva "
            //};
            //
            //string[] cities =
            //{
            //    "Burgas ", "Sofia ", "Plovdiv ", "Varna ", "Ruse "
            //};
            File.Delete("output.txt");
            string[] phrases = File.ReadAllLines("phrases.txt");
            string[] events = File.ReadAllLines("events.txt");
            string[] authors = File.ReadAllLines("authors.txt");
            string[] cities = File.ReadAllLines("cities.txt");
            //int numberOfMessages = int.Parse(Console.ReadLine());
            string numberOfMessages = File.ReadAllText("input.txt");
            int num = int.Parse(numberOfMessages);
            Random rnd = new Random();

            for (int i = 0; i < num; i++)
            {
                string result = string.Format("{0} {1} {2} - {3}", phrases[rnd.Next(0, 6)], events[rnd.Next(0, 6)], authors[rnd.Next(0, 8)], cities[rnd.Next(0, 5)] + Environment.NewLine);
                File.AppendAllText("output.txt", result);
            }

        }
    }
}


