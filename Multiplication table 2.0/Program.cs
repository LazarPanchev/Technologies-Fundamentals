using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplayer = int.Parse(Console.ReadLine());
            int product = 1;
            if(multiplayer>10)
            {
                Console.WriteLine($"{number} X {multiplayer} = {number*multiplayer}");
            }
            for (int i = multiplayer; i <= 10; i++)
            {
                
                product = number * i;
                Console.WriteLine($"{number} X {i} = {product}");
            }
        }
    }
}
