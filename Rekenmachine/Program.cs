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
            // reading input from console eg "7+3" => "10"
            string _calculationString;
            Console.WriteLine("'String' calculator +-*/");
            Console.WriteLine("Enter calculation (7+3): ");
            _calculationString = Console.ReadLine();
            //_calculationString = "7+3";

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
        }
    }
}