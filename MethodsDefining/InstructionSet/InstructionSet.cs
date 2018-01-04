namespace InstructionSet
{
    using System;

    public class InstructionSet
    {
        public static void Main()
        {
            string instructionString = Console.ReadLine();


            while (instructionString != "END")
            {
                string[] codeArgs = instructionString.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            operandOne++;
                            result = operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            operandOne--;
                            result = operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result =operandOne * operandTwo;
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }
                instructionString = Console.ReadLine();
                Console.WriteLine(result);
            }
        }
    }
}
