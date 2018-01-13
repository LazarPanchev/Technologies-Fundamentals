namespace PriceChangeAlert
{
    using System;
    public class PriceChangeAlert
    {
        public static void Main()
        {
            int numberOfStockPrices = int.Parse(Console.ReadLine());
            double notificationLimit = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStockPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double currentPercentage = GetPercentage(lastPrice, currentPrice);
                bool isSignificantDifference = HasDifference(currentPercentage, notificationLimit);

                string message = GetNotification(currentPrice, lastPrice, currentPercentage, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        public static string GetNotification(double currentPrice, double lastPrice, double difference, bool hasDifference)
        {
            string priceChange = string.Empty;
            if (difference == 0)
            {
                priceChange = string.Format("NO CHANGE: {0}", currentPrice);
            }

            else if (!hasDifference)
            {
                priceChange = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
            }

            else if (hasDifference && (difference > 0))
            {
                priceChange = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
            }

            else if (hasDifference && (difference < 0))
            {
                priceChange = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
            }

            return priceChange;
        }
        public static bool HasDifference(double limit, double notificationLimit)
        {
            if (Math.Abs(limit) >= notificationLimit)
            {
                return true;
            }

            return false;
        }

        public static double GetPercentage(double lastPrice, double currentPrice)
        {
            return ((currentPrice - lastPrice) / lastPrice);
        }
    }
}

