
namespace DataOverflow
{
    using System;
    public class DataOverflow
    {
        public static void Main()
        {
            ulong firstNumber = ulong.Parse(Console.ReadLine());
            ulong secondNumber= ulong.Parse(Console.ReadLine());
            ulong biggerNumber = 0;
            ulong smallerNumber = 0;
            string typeBigger = string.Empty;
            string typeSmaller = string.Empty;

            if (firstNumber>secondNumber)
            {
                biggerNumber = firstNumber;
                smallerNumber = secondNumber;
            }
            else
            {
                biggerNumber = secondNumber;
                smallerNumber = firstNumber;
            }
            if(biggerNumber >= byte.MinValue && biggerNumber <= byte.MaxValue)
            {
                typeBigger = "byte";
            }
            else if (biggerNumber >= ushort.MinValue && biggerNumber <= ushort.MaxValue)
            {
                typeBigger = "ushort";
            }
            else if (biggerNumber >= uint.MinValue && biggerNumber <= uint.MaxValue)
            {
                typeBigger = "uint";
            }
            else if(biggerNumber >= ulong.MinValue && biggerNumber <= ulong.MaxValue)
            {
                typeBigger = "ulong";
            }
            ulong maxValue = 0U;
            if (smallerNumber >= byte.MinValue && smallerNumber <= byte.MaxValue)
            {
                typeSmaller = "byte";
                maxValue = byte.MaxValue;
            }
            else if (smallerNumber >= ushort.MinValue && smallerNumber <= ushort.MaxValue)
            {
                typeSmaller = "ushort";
                maxValue = ushort.MaxValue;
            }
            else if (smallerNumber >= uint.MinValue && smallerNumber <= uint.MaxValue)
            {
                typeSmaller = "uint";
                maxValue = uint.MaxValue;
            }
            else if (smallerNumber >= ulong.MinValue && smallerNumber <= ulong.MaxValue)
            {
                typeSmaller = "ulong";
                maxValue = ulong.MaxValue;
            }
            double overflow = Math.Round((double)biggerNumber / maxValue);
            Console.WriteLine("bigger type: {0}", typeBigger);
            Console.WriteLine("smaller type: {0}", typeSmaller);
            Console.WriteLine($"{biggerNumber} can overflow {typeSmaller} {overflow} times");
        }
    }
}
