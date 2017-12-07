using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int counter = 0;
            while(command!="Bake!")
            {
                Console.WriteLine("Adding ingredient {0}.",command);
                counter++;
                command = Console.ReadLine();

            }
            Console.WriteLine("Preparing cake with {0} ingredients.",counter);
        }
    }
}
