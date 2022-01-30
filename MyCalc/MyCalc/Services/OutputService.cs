using System;


namespace MyCalc.Services
{
    public class OutputService
    {
        internal void Print(string message)
        {
            if(message == null) throw new ArgumentNullException(nameof(message));
            Console.WriteLine(message);
        }
    }
}
