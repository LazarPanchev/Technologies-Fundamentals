using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04_05._11._17_Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, BigInteger>> officialData = new Dictionary<string, Dictionary<string, BigInteger>>();
            Dictionary<string, Dictionary<string, BigInteger>> cacheData = new Dictionary<string, Dictionary<string, BigInteger>>();

            while (input != "thetinggoesskrra")
            {
                string dataKey = "";
                BigInteger dataSize = 0;
                string dataSet = "";

                if (input.Contains("|"))
                {
                    string[] arr = input.Split(new char[] { ' ', ',', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    dataKey = arr[0];
                    dataSize = BigInteger.Parse(arr[1]);
                    dataSet = arr[2];

                    Dictionary<string, BigInteger> current = new Dictionary<string, BigInteger>

                    {
                        { dataKey, dataSize }
                    };

                    if (officialData.ContainsKey(dataSet) == false)
                    {

                        if (cacheData.ContainsKey(dataSet) == false)
                        {
                            cacheData.Add(dataSet, current);
                        }
                        else
                        {
                            cacheData[dataSet].Add(dataKey, dataSize);
                        }

                    }
                    else
                    {
                        officialData[dataSet].Add(dataKey, dataSize);
                    }
                }

                else
                {
                    dataSet = input;

                    if (officialData.ContainsKey(dataSet) == false)
                    {
                        Dictionary<string, BigInteger> current = new Dictionary<string, BigInteger>();

                        officialData.Add(dataSet, current);

                        if (cacheData.ContainsKey(dataSet))
                        {
                            officialData[dataSet] = cacheData[dataSet];
                        }
                    }
                }

                input = Console.ReadLine();

            }

            BigInteger sum = 0;
            BigInteger sumMax = 0;
            string setMax = "";

            foreach (var set in officialData)
            {
                foreach (var pair in set.Value)
                {
                    sum += pair.Value;
                }
                if (sum > sumMax)
                {
                    sumMax = sum;
                    setMax = set.Key;
                    sum = 0;
                }
            }

            if (officialData.Count == 0)
            {
                return;
            }

            Console.WriteLine($"Data Set: {setMax}, Total Size: {sumMax}");

            foreach (var item in officialData[setMax])
            {
                Console.WriteLine($"$.{item.Key}");
            }
        }
    }
}