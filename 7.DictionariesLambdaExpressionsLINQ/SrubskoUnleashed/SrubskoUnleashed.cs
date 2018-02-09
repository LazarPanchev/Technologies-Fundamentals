using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SrubskoUnleashed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dictionary = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                if (IsValidInput(input))
                {
                    string[] tokens = input.Split(new string[] { " @" }, StringSplitOptions.RemoveEmptyEntries);
                    string singer = tokens[0];
                    string venueAndTickets = tokens[1];
                    string[] venueAndTicketsTokens = venueAndTickets.Split(' ');
                    string[] venuePlace = venueAndTicketsTokens.Reverse().Skip(2).ToArray();
                    Array.Reverse(venuePlace);
                    string venue = string.Empty;
                    for (int i = 0; i < venuePlace.Length; i++)
                    {
                        if (i == venuePlace.Length - 1)
                        {
                            venue += venuePlace[i];
                        }
                        else
                        {
                            venue += venuePlace[i] + " ";
                        }

                    }

                    long ticketPrice = ExtractData(venueAndTicketsTokens, venueAndTicketsTokens.Length - 2);
                    long ticketsCount = ExtractData(venueAndTicketsTokens, venueAndTicketsTokens.Length - 1);
                    long totalMount = ticketPrice * ticketsCount;

                    if (!dictionary.ContainsKey(venue))
                    {
                        dictionary.Add(venue, new Dictionary<string, long>());
                    }

                    if (!dictionary[venue].ContainsKey(singer))
                    {
                        dictionary[venue].Add(singer, 0);
                    }

                    dictionary[venue][singer] += totalMount;

                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> pair in dictionary)
            {
                string venue = pair.Key;
                Console.WriteLine(venue);
                Dictionary<string, long> singersAndTickets = pair.Value;
                foreach (KeyValuePair<string, long> nestedPair in singersAndTickets.OrderByDescending(x => x.Value))
                {
                    string singer = nestedPair.Key;
                    long totalMount = nestedPair.Value;
                    Console.WriteLine("#  {0} -> {1}", singer, totalMount);
                }
            }
        }


        private static long ExtractData(string[] tokens, long index)
        {
            return long.Parse(tokens[index]);
        }

        public static bool IsValidInput(string input)
        {
            string[] tokens = input.Split(' ');
            if (tokens.Length >= 4)
            {
                string[] tokenses = input.Split(new string[] { " @" }, StringSplitOptions.RemoveEmptyEntries);
                if (tokenses.Length == 1)
                {
                    return false;
                }
                long ticketPrice = 0;
                long ticketCount = 0;
                string ticket = tokens[tokens.Length - 2];
                string count = tokens[tokens.Length - 1];
                bool IsThereTicket = long.TryParse(ticket, out ticketPrice);
                bool IsThereCount = long.TryParse(count, out ticketCount);
                if (IsThereCount && IsThereTicket)
                {
                    return true;
                }
            }

            else
            {
                return false;
            }

            return false;
        }
    }
}

