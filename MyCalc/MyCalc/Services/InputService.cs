using System;


namespace MyCalc.Services
{
    internal class InputService
    {
        private readonly OutputService _outputService;
            public InputService(OutputService outputService)
        {
            _outputService = outputService;
        }
        public float GetNumber()
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
                    _outputService.Print("Wrong number, please try again enter float number.");
                }

            } while (!isInputValid);

            return number;
        }
    }
}
