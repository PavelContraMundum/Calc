using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalc.Services
{
    public class InputOperandService
    {
        private readonly OutputService _outputService;
        private readonly InputStringService _inputStringService;
        public InputOperandService(OutputService outputService, InputStringService inputStringService)
        {
            _outputService = outputService;
        }
        public OperandType GetOperand()
        {
            _outputService.Print("Enter operand + - * /");
            var operandString = _inputStringService.GetStringFromUser();

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
