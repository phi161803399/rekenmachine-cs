using System;

namespace Rekenmachine
{
    class Message
    {
        public static string InputMessage()
        {
            string input;
            bool validated;
            do
            {
                // reading input from console eg "7+3" => "10"
                Console.WriteLine("'String' calculator +-*/");
                Console.WriteLine("Enter calculation (7+3): ");
                input = Console.ReadLine();
                //input = "5*3*2";
                validated = Validation.Validated(input);
                if (validated != true)
                {
                    Console.WriteLine("Invalid input");
                }
            } while (validated == false);
            return input;
        }
    }
}
