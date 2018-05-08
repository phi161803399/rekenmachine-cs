using System;
using System.Collections.Generic;
using Rekenmachine.Calculators;

namespace Rekenmachine
{
    class Program
    {
        static void Main()
        {
            Operand op1 = new Operand(1.5m);
            Operand op2 = new Operand();
            op2.Waarde = 2.3m;
            Console.WriteLine("{0}", op2.Waarde);
            Operand op3 = new Operand(3.7m);
            List<Operand> opList = new List<Operand>();
            opList.Add(op1);
            opList.Add(op2);
            opList.Add(op3);
            foreach (Operand operand in opList)
            {
                Console.WriteLine("{0}", operand.Waarde);
            }

            
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