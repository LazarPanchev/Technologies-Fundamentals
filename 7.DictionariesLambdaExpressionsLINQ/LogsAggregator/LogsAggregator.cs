using System;
using System.Linq;
using System.Collections.Generic;

namespace LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            Dictionary<string, int> dictDuration = new Dictionary<string, int>();
            Dictionary<string, List<string>> dictIpAdress = new Dictionary<string, List<string>>();

            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string ipAdress = input[0];
                string name = input[1];
                int duration = int.Parse(input[2]);

                if(! dictDuration.ContainsKey(name))
                {
                    dictDuration[name] = 0;
                }

                dictDuration[name] += duration;

                if(! dictIpAdress.ContainsKey(name))
                {
                    dictIpAdress[name] = new List<string>();
                }

                dictIpAdress[name].Add(ipAdress);
            }

            foreach(KeyValuePair<string,int> pair in dictDuration.OrderBy(x=>x.Key))
            {
                string name = pair.Key;
                int duration = pair.Value;
                Console.Write("{0}: {1} ",name,duration);
                List<string> ipAdresses = dictIpAdress[name].Distinct().ToList();
                Console.Write("[");
                Console.Write(string.Join(", ",ipAdresses.OrderBy(x=>x)));
                Console.WriteLine("]");
            }
        }
    }
}
