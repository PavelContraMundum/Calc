using System;

namespace Mycalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator v1.0.0");


            //Getting first number
            Console.WriteLine("Enter first number (float)");
            var number1 = GetNumber();
            if(number1 is null)
            {
                Console.WriteLine("Wrong number. Good bye.");
                return;
             }


            //Getting second number
            Console.WriteLine("Enter second number (float)");
            var number2 = GetNumber();
            if (number2 is null)
            {
                Console.WriteLine("Wrong number. Good bye.");
                return;
            }

            //Getting operand

            Console.WriteLine("Enter operand + - * /");
            var operand = Console.ReadLine();

            //Calculation

            float result = 0;
            switch (operand)
            {
                case "+": 
                    result = number1.Value + number2.Value;
                    break;
                case "-":
                    result = number1.Value - number2.Value;
                    break;
                case "*":
                    result = number1.Value * number2.Value;
                    break;
                case "/":
                    if(number2 == 0)
                    {
                        Console.WriteLine("Divide by zero. Error.");
                    }
                    result = number1.Value / number2.Value;
                    break;
                default:
                    Console.WriteLine("Wrong operand. Good bye!");
                    return;
            }

           
            //Show result

            Console.WriteLine(result);

        }

        private static float? GetNumber()
        {
            var numberString = Console.ReadLine();
            var isOkNumber1 = float.TryParse(numberString, out var number);
            if (!isOkNumber1)
            {
                return null;
            }
            return number;
        }
    }
}

