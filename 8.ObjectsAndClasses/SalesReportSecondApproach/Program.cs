﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReport
{
    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return Quantity * Price;
            }
        }
    }

    public class SalesReport
    {
        public static void Main()
        {
            SortedDictionary<string, List<Sale>> allSales = new SortedDictionary<string, List<Sale>>();
            int nLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < nLines; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                Sale sale = new Sale
                {
                    Town = tokens[0],
                    Product = tokens[1],
                    Price = decimal.Parse(tokens[2]),
                    Quantity = decimal.Parse(tokens[3])
                };
                string currentTown = sale.Town;
                if (!allSales.ContainsKey(currentTown))
                {
                    allSales.Add(currentTown, new List<Sale>());
                }
                allSales[currentTown].Add(sale);
            }

            foreach (var pair in allSales)
            {
                string town = pair.Key;
                List<Sale> saleslist = pair.Value;
                decimal totalPrice = saleslist.Sum(x => x.Quantity * x.Price);
                Console.WriteLine("{0} -> {1:F2}", town, totalPrice);
            }

        }
    }
}

