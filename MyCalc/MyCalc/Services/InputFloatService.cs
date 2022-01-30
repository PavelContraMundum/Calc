using System;


namespace MyCalc.Services
{
    internal class InputFloatService
    {
        private readonly OutputService _outputService;
        private readonly InputStringService _inputStringService;
            public InputFloatService(OutputService outputService, InputStringService inputStringService)
        {
            _outputService = outputService;
            _inputStringService = inputStringService;
        }
        public float GetNumber()
        {
            float number;
            bool isInputValid;
            do
            {
                var numberString = _inputStringService.GetStringFromUser();
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
