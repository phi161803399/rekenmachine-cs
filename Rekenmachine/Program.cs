using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
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
                Console.WriteLine(req.Val);
                //Output.Message(req.());

                // keep active                
                keepActive = Active.KeepActive();
            } while (keepActive);           
        }
    }
}