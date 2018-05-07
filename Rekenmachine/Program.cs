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
                
                Console.WriteLine("Left: {0}", req.LeftHand);
                Console.WriteLine("Right: {0}", req.RightHand);
                Console.WriteLine("Operation: {0}", req.Operation );
                Console.WriteLine("Result: {0}", req.Calculate());

                // keep active                
                keepActive = Active.KeepActive();
            } while (keepActive);           
        }
    }
}