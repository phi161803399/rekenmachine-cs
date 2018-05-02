using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main()
        {
            bool keepActive;
            do
            {
                // input message
                string calculationString = Message.InputMessage();

                // calculating output
                int result = Operation.Calculate(calculationString);
                Console.WriteLine(result == 1000 ? "No valid operator" : $"Result: {result}");
                
                // keep active                
                keepActive = Active.KeepActive();
            } while (keepActive);           
        }
    }
}