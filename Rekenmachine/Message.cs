using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class Message
    {
        public static string InputMessage()
        {
            // reading input from console eg "7+3" => "10"
            string _input;
            Console.WriteLine("'String' calculator +-*/");
            Console.WriteLine("Enter calculation (7+3): ");
            _input = Console.ReadLine();
            //_input = "7+3";
            return _input;
        }
    }
}
