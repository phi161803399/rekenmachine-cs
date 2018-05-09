using System;
using System.Collections.Generic;
using Rekenmachine.Calculators;

namespace Rekenmachine
{
    class Program
    {
        static void Main()
        {
            var a = new Request();
            var b = new Request();
            var c = new Request();
            var x = new Request();
            var y = new Request();
            a.val = 2;
            x.Operation = OperationType.product;
            b.val = 3;
            x.LeftHand = a;
            x.RightHand = b;
            y.LeftHand = x;
            y.Operation = OperationType.product;
            y.RightHand = new Request(){val = 5};        


            Console.WriteLine(y.val);

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