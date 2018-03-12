using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Npower = decimal.Parse(Console.ReadLine());
            int Mdistance = int.Parse(Console.ReadLine());
            int YexhaustFactor = int.Parse(Console.ReadLine());

            int counter = 0;
            decimal originalValueOfNpower = Npower;
            decimal halfValue = 0.5M * originalValueOfNpower;
            while (Mdistance <= Npower)
            {
                Npower -= Mdistance;
                counter++;


                if (Npower == halfValue && YexhaustFactor != 0)
                {
                    Npower = (int)Npower / YexhaustFactor;
                }
            }

            Console.WriteLine(Npower);
            Console.WriteLine(counter);
        }
    }
}
