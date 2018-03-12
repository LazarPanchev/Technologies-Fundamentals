using System;
using System.Collections.Generic;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int NCountsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            List<string> affectedSites = new List<string>();
            //{siteName} {siteVisits} {siteCommercialPricePerVisit}
            decimal totalLoss = 0;
            //var securityToken = 0;
            for (int i = 0; i < NCountsites; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string siteName = tokens[0];
                decimal siteVisits = decimal.Parse(tokens[1]);
                decimal pricePerVisit = decimal.Parse(tokens[2]);

                decimal siteLoss = siteVisits * pricePerVisit;
                totalLoss += siteLoss;
                affectedSites.Add(siteName);
            }
            BigInteger secToken = BigInteger.Pow(securityKey, affectedSites.Count);

            Console.WriteLine(string.Join(Environment.NewLine,affectedSites));
            Console.WriteLine("Total Loss: {0:F20}",totalLoss);
            Console.WriteLine("Security Token: {0}",secToken);
        }
    }
}
