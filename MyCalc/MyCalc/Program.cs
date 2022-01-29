using System;

namespace Mycalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator v1.0.0");


            //Getting first number
            string? numberString1 = Console.ReadLine();
            float number1 = float.Parse(numberString1 ?? "0");




            //Getting second number

            string? numberString2 = Console.ReadLine();
            float number2 = float.Parse(numberString2 ?? "0");

            //Getting operand

            
            string? operand = Console.ReadLine();

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
                    result = number1 / number2;
                    break;

            }

           
            //Show result

            Console.WriteLine(result);

        }
    }
}

