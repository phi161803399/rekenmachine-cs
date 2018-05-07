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
                
                var req = new Request(calculationString);
                //req.Calc();
                
                Console.WriteLine("Left: {0}", req.LeftHand);
                Console.WriteLine("Right: {0}", req.RightHand);
                Console.WriteLine("Operation: {0}", req.Operation );
                // keep active                
                keepActive = Active.KeepActive();
            } while (keepActive);           
        }
    }
}