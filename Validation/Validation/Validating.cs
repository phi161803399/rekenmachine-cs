using System;
using System.Text.RegularExpressions;

namespace Validation
{
    class Validating
    {
        public static void Validate()
        {
            string pattern = @"[0-9*/+-]+";
            string[] inputs = {"0*9", "010   + 2", "2344/9"};
            foreach (var input in inputs)
            {
                Match m = Regex.Match(input, pattern);

                if (m.Success)
                {
                    Console.WriteLine("Match: {0}", m.Value);
                }
                else
                {
                    Console.WriteLine("Input {0} failed.", input);
                }
            }
        }
    }
}
