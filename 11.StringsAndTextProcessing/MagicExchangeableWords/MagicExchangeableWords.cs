﻿using System;
using System.Linq;
using System.Text;
namespace MagicExchangeableWords
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            string wordOne = input[0];
            string wordTwo = input[1];

            var arrayOne = wordOne.ToCharArray().Distinct().ToArray();
            var arrayTwo = wordTwo.ToCharArray().Distinct().ToArray();

            if(arrayOne.Length==arrayTwo.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
