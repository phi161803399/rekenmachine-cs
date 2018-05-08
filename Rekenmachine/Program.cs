using System;
using Rekenmachine.Calculators;

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
                
                var req = new Request(calculationString);              
                
                Output.Message(req);

                // keep active                
                keepActive = Active.KeepActive();
            } while (keepActive);           
        }
    }
}