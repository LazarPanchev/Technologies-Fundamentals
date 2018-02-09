using System;
using System.Linq;
using System.Collections.Generic;

namespace UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> dictionary = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                string[] ipAdressString = tokens[0].Split('=');
                string ipAdress = ipAdressString[1];

                string[] massageString = tokens[1].Split('=');
                string massage = massageString[1];

                string[] userNameString = tokens[2].Split('=');
                string userName = userNameString[1];

                if (!dictionary.ContainsKey(userName))
                {
                    dictionary.Add(userName, new Dictionary<string, int>());
                }

                if (!dictionary[userName].ContainsKey(ipAdress))
                {
                    dictionary[userName].Add(ipAdress, 0);
                }

                dictionary[userName][ipAdress]++;

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> pair in dictionary)
            {
                string result = "";
                string printResult = "";
                string userName = pair.Key;
                Dictionary<string, int> ipAdressCount = pair.Value;
                Console.WriteLine("{0}: ", userName);

                foreach (KeyValuePair<string, int> secondPair in ipAdressCount)
                {
                    string ipAdress = secondPair.Key;
                    int countVisits = secondPair.Value;
                    result = $"{ipAdress} => {countVisits}";
                    printResult += result + ", ";
                }

                Console.WriteLine("{0}.", printResult.TrimEnd(new char[] { ' ', ',' }));
            }
        }
    }
}
