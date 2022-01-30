using MyCalc;
using MyCalc.Services;
using System;

namespace Mycalc
{
    class Program
    {
        static void Main(string[] args)
        {

            //vytvoření instance
            var outputService = new OutputService();
            var inputService = new InputService(outputService);

            outputService.Print("Calculator v1.0.0");


            //Getting first number
            outputService.Print("Enter first number (float)");
            
            var number1 = inputService.GetNumber();


            //Getting second number
            outputService.Print("Enter second number (float)");
         
            var number2 = inputService.GetNumber();
           

            //Getting operand

            
            var operand = GetOperand();
            if(operand == OperandType.None)
            {
                outputService.Print("Wrong operand. Good bye.");
                return;
            }

            //Calculation

            var result = Calculate(number1, number2, operand);

            if(result is not null)
            {
                outputService.Print(result.Value.ToString("F"));
            }
             
            
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

    }
}

