using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepActive;
            do
            {
                // input message
                string _calculationString = Message.InputMessage();

                // finding index of operator

                // parsing input

                // calculating output
                int _result = Operation.Calculate(_calculationString);
                if (_result == 1000)
                {
                    Console.WriteLine("No valid operator");
                }
                else
                    Console.WriteLine($"Result: {_result}");

                // keep active                
                keepActive = Active.KeepActive();
            } while (keepActive == true);           
        }
    }
}