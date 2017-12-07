using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine(num);
                
                
                sum += num;
                num += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
