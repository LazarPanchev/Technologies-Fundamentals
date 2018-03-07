using System;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexMon
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string bojomonPattern = @"([A-Za-z]+\-[A-Za-z]+)";
            string didimonPattern = @"(^|(?<=[^\s]))([^A-Za-z\-]+)($|(?=[^\s]))";

            Regex bojomon = new Regex(bojomonPattern);
            Regex didimon = new Regex(didimonPattern);
            bool bojoTurn = false;
            bool didiTurn = true;
            int startIndex = 0;
            while (startIndex<=input.Length-1)
            {
                Match didiMatch = didimon.Match(input,startIndex);
                if(didimon.IsMatch(input, startIndex) && didiTurn)
                {
                    string match = didiMatch.Groups[2].Value;
                    int index = input.IndexOf(match,startIndex);
                    Console.WriteLine(match);
                    int indexUpTohere = input.IndexOf(match,index);
                    int lenghtText = match.Length;
                    startIndex =indexUpTohere + lenghtText;
                    bojoTurn = true;
                }

                else
                {
                    break;
                }

                Match bojoMatch = bojomon.Match(input,startIndex);
                if(bojomon.IsMatch(input,startIndex) && bojoTurn)
                {
                    string match = bojoMatch.Groups[1].Value;
                    int index = input.IndexOf(match, startIndex);
                    Console.WriteLine(match);
                    int indexUpTohere = input.IndexOf(match,index);
                    int lenghtText = match.Length;
                    startIndex =indexUpTohere+ lenghtText;
                    didiTurn = true;
                }

                else
                {
                    break;
                }
            }


        }
    }
}
