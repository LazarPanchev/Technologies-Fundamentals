
namespace BeerKegs
{
    using System;
    public class BeerKegs
    {
        public static void Main()
        {
            int nLines = int.Parse(Console.ReadLine());
            double volumeKeg = 0.0;
            double maxVolumeKeg = 0.0;
            string biggestKeg = string.Empty;
            for (int i = 0; i < nLines; i++)
            {
                string modelKeg = Console.ReadLine();
                double radiusKeg = double.Parse(Console.ReadLine());
                int heightKeg = int.Parse(Console.ReadLine());
                volumeKeg = Math.PI * radiusKeg * radiusKeg * heightKeg;
                if(volumeKeg>maxVolumeKeg)
                {
                    maxVolumeKeg = volumeKeg;
                    biggestKeg = modelKeg;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
