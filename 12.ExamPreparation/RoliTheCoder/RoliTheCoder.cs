using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, List<string>> dictNameList = new Dictionary<string, List<string>>();

            Dictionary<int, string> dictIdName = new Dictionary<int, string>();

            while (input != "Time for Code")
            {
                var split = input.Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries);

                var id = int.Parse(split[0]);
                var eventName = split[1];
                var participants = split.Skip(2).ToList();

                if (eventName[0] != '#')
                {

                }
                else
                {
                    if (dictIdName.ContainsKey(id))
                    {
                        if (dictIdName[id] == eventName)
                        {
                            foreach (var name in participants)
                            {
                                if (!dictNameList[eventName].Contains(name))
                                    dictNameList[eventName].Add(name);
                            }
                        }
                    }
                    else if (!dictIdName.ContainsKey(id))
                    {
                        dictNameList[eventName] = new List<string>();
                        dictIdName[id] = eventName;
                        foreach (var name in participants)
                        {
                            if (!dictNameList[eventName].Contains(name))
                            {
                                dictNameList[eventName].Add(name);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var eventt in dictNameList
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{eventt.Key.Remove(0, 1)} - {eventt.Value.Count}");
                foreach (var name in eventt.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"{name}");
                }
            }
        }
    }
}