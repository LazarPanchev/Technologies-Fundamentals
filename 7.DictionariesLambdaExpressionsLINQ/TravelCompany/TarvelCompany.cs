using System;
using System.Linq;
using System.Collections.Generic;

namespace TravelCompany
{
    public class Program
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();

            while (command != "ready")
            {
                string[] inputLine = command.Split(':');
                string cityKey = inputLine[0];
                string[] transportAndCapacity = inputLine[1].Split(',');
                foreach (string item in transportAndCapacity)
                {
                    string[] vehCap = item.Split('-');
                    string vehicle = vehCap[0];
                    int capacity = int.Parse(vehCap[1]);//ok

                    if(! dictionary.ContainsKey(cityKey))
                    {
                        dictionary[cityKey] = new Dictionary<string, int>();
                    }

                    if(dictionary[cityKey].ContainsKey(vehicle))
                    {
                        dictionary[cityKey][vehicle] = capacity;
                    }
                    else
                    {
                        dictionary[cityKey].Add(vehicle, capacity);
                    }                
                }
                //ok
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "travel time!")
            {
                string[] secondInput = command.Split(' ');
                string accommodateCity = secondInput[0];
                int peopleForAccommodate = int.Parse(secondInput[1]);
                foreach (KeyValuePair<string,Dictionary<string,int>> pair  in dictionary)
                {
                    string key = pair.Key;
                    Dictionary<string, int> valueDict = pair.Value;
                    int allSeatsForTheTown = 0;
                    foreach (KeyValuePair<string,int> secondPair in valueDict)
                    {
                        string vehicleKey = secondPair.Key;
                        int capacity = secondPair.Value;
                        allSeatsForTheTown += capacity;
                    }

                    if(key==accommodateCity)
                    {
                        if(peopleForAccommodate <= allSeatsForTheTown)
                        {
                            Console.WriteLine("{0} -> all {1} accommodated", accommodateCity, peopleForAccommodate);
                        }

                        else
                        {
                            Console.WriteLine("{0} -> all except {1} accommodated", accommodateCity, peopleForAccommodate-allSeatsForTheTown );
                        }
                    }
                }

                command = Console.ReadLine();
                
            }
        }
    }
}
