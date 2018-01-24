namespace Phone
{
    using System;
    using System.Linq;

    public class Phone
    {
        static string[] numbers;
        static string[] names;
        public static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split(' ');
            names = Console.ReadLine().Split(' ');

            string[] inputTokens = Console.ReadLine().Split();

            while (inputTokens[0] != "done")
            {
                string command = inputTokens[0];
<<<<<<< HEAD
                string argument = inputTokens[1];
=======
                string argument = inputTokens[1]; 
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852
                string name;
                string telefoneNumber;
                string output;

<<<<<<< HEAD
                if (IsNumber(argument))
=======
                if(IsNumber(argument))
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852
                {
                    name = GetEntry(argument);
                    telefoneNumber = argument;
                    output = name;
                }

                else
                {
                    name = argument;
                    telefoneNumber = GetEntry(argument);
                    output = telefoneNumber;
                }

                int digitSum = GetDigitSum(telefoneNumber);

<<<<<<< HEAD
                if (command == "call")
                {
                    Console.WriteLine("calling {0}...", output);
                    if (digitSum % 2 == 1)
=======
                if(command=="call")
                {
                    Console.WriteLine("calling {0}...", output);
                    if(digitSum%2==1)
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        int minutes = digitSum / 60;
                        int seconds = digitSum % 60;
                        Console.WriteLine("call ended. duration: {0}:{1}",
                            minutes.ToString().PadLeft(2, '0'),
                            seconds.ToString().PadLeft(2, '0'));
                    }
<<<<<<< HEAD

=======
                
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852
                }

                else
                {
                    Console.WriteLine("sending sms to {0}...", output);
                    if (digitSum % 2 == 1)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");

                    }
                }



                inputTokens = Console.ReadLine().Split(' ');
            }
        }

        public static int GetDigitSum(string telephoneNumber)
        {
            int sum = 0;
            for (int i = 0; i < telephoneNumber.Length; i++)
            {
<<<<<<< HEAD
                if (IsDigit(telephoneNumber[i]))
=======
                if(IsDigit(telephoneNumber[i]))
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852
                {
                    sum += telephoneNumber[i] - '0';
                }
            }

            return sum;
        }

        public static string GetEntry(string input)  //if is number return name and if is a name return number
        {
            for (int i = 0; i < numbers.Length; i++)
            {
<<<<<<< HEAD
                if (names[i] == input)
=======
                if(names[i]==input)  
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852
                {
                    return numbers[i];
                }

<<<<<<< HEAD
                else if (numbers[i] == input)
=======
                else if(numbers[i] == input)
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852
                {
                    return names[i];
                }
            }

            return string.Empty;
        }
<<<<<<< HEAD

=======
    
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852


        public static bool IsNumber(string input)  // return true if is a number, and no if it's not.
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (IsDigit(input[i]))
                {
                    return true;
                }
            }
<<<<<<< HEAD
            return false;
=======
           return false;
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852
        }

        public static bool IsDigit(char symbol)
        {
            return (symbol >= '0' && symbol <= '9');
        }
    }
}
<<<<<<< HEAD

=======
>>>>>>> 0ae1e6acdaed4ed32134dca020bef60f7e4ff852
