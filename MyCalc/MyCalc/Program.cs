using MyCalc;
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
           

            //Getting second number
            Console.WriteLine("Enter second number (float)");
            var number2 = GetNumber();
           

            //Getting operand

            
            var operand = GetOperand();
            if(operand == OperandType.None)
            {
                Console.WriteLine("Wrong operand. Good bye.");
                return;
            }

            //Calculation

            var result = Calculate(number1, number2, operand);
            

           
            //Show result

            Console.WriteLine(result);

        }

        private static float? Calculate(float number1, float number2, OperandType operand)
        {
            switch (operand)
            {
                case OperandType.Addition:
                    return number1 + number2;
                    
                case OperandType.Subtraction:
                    return number1 - number2;
                    
                case OperandType.Multiplication:
                    return number1 * number2;
                   
                case OperandType.Division:
                    if (number2 == 0)
                    {
                        Console.WriteLine("Divide by zero. Error.");
                        return null;
                    }
                    return number1 / number2;
                   
               
            }
                    return null;
        }

        private static OperandType GetOperand()
        {
            Console.WriteLine("Enter operand + - * /");
            var operandString = Console.ReadLine();

            return operandString switch
            {
                "+" => OperandType.Addition,
                "-" => OperandType.Subtraction,
                "*" => OperandType.Multiplication,
                "/" => OperandType.Division,
                _ => OperandType.None,

            };
        }

        private static float GetNumber()
        {
            float number;
            bool isInputValid;
            do
            {
                var numberString = Console.ReadLine();
                var numberParsed = float.TryParse(numberString, out number);
                 isInputValid = numberParsed;
                if (!numberParsed)
                {
                    Console.WriteLine("Wrong number, please try again enter float number.");
                }

            } while (!isInputValid);
            
            return number;
        }
    }
}

