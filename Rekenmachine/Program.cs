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
            var a = new Request();
            var b = new Request();
            var c = new Request();
            var x = new Request();
            var y = new Request();
            a.Val = 2;
            b.Val = 3;

            x.LeftHand = a;
            x.Operation = OperationType.product;
            x.RightHand = b;

            y.LeftHand = x;
            y.Operation = OperationType.product;
            y.RightHand = new Request(){Val = 5};        


            Console.WriteLine(y.Val);

            bool keepActive;
            do
            {
                // input message
                string calculationString = Message.InputMessage();
                
                var req = new Request(calculationString);              
                
                Console.WriteLine("input: "+ calculationString);
                Console.WriteLine("output: " + req);
                //Output.Message(req.());

                // keep active                
                keepActive = Active.KeepActive();
            } while (keepActive);           
        }
    }
}