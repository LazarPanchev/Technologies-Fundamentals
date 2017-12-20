

namespace VowelOrDigit
{
    using System;
    public class StratUp
    {
        public static void Main()
        {

            char input = char.Parse(Console.ReadLine());
            if((input>=48) && (input<=57))
            {
                Console.WriteLine("digit");
            }
            else 
            {
                switch((int)input)
                {
                    case 97:
                    case 101:
                    case 105:
                    case 111:
                    case 117:
                    case 121:
                    case 65:
                    case 69:
                    case 73:
                    case 79:
                    case 85:
                    case 89:
                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("other");
                        break;
                }
            }

                

            

        }
    }
}
