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
            var numberString1 = Console.ReadLine();
            var isOkNumber1 = float.TryParse(numberString1, out var number1 );
            if (!isOkNumber1)
            {
                Console.WriteLine("Wrong number. Good bye.");
            }



            //Getting second number
            Console.WriteLine("Enter second number (float)");
            var numberString2 = Console.ReadLine();
            var isOkNumber2 = float.TryParse(numberString2, out var number2);
            if (!isOkNumber2)
            {
                Console.WriteLine("Wrong number. Good bye.");
            }

            //Getting operand

            Console.WriteLine("Enter operand + - * /");
            var operand = Console.ReadLine();

            //Calculation

            float result = 0;
            switch (operand)
            {
                case "+": 
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if(number2 == 0)
                    {
                        Console.WriteLine("Divide by zero. Error.");
                    }
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Wrong operand. Good bye!");
                    return;
            }

           
            //Show result

            Console.WriteLine(result);

        }
    }
}

