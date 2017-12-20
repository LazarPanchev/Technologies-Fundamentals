using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int counter = 1;
            string attacker = string.Empty;
            while((peshoHealth>=0) || (goshoHealth>=0))
            {
                
                if(counter%2!=0)
                {
                    goshoHealth -= peshoDamage;
                    attacker = $"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.";
                }
                else
                {
                    peshoHealth -= goshoDamage;
                    attacker= $"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.";
                }
                if(goshoHealth<=0 || peshoHealth<=0)
                {
                    break;
                }
                Console.WriteLine(attacker);
                attacker = string.Empty;
                if(counter%3==0)
                {
                     peshoHealth += 10;
                     goshoHealth += 10;
                }
                
                counter++;
            }
            if(peshoHealth>goshoHealth)
            {
                Console.WriteLine("Pesho won in {0}th round.",counter);
            }
            else
            {
                Console.WriteLine("Gosho won in {0}th round.", counter);

            }
        }
    }
}
