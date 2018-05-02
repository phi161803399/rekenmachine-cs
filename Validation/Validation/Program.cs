using System;
using System.Text.RegularExpressions;

namespace Validation
{
    class Program
    {
        static void Main()
        {
            //string pattern = @"(\w)\1";
            //string[] inputs = { "ee"};
            string pattern = @"([0-9]+)\s*([*/+-])\s*([0-9]+)";
            //string[] inputs = { "0*9", "010   + 2", "2344/9", "a+8", "98", "(8+3", "(8+3)", "8+3)", "1+(2*3)" };
            string[] inputs = { "0*9", "010   + 2", "2344/9" };
            foreach (var input in inputs)
            {
                Match m = Regex.Match(input, pattern);
                
                if (m.Success)
                {
                    double result;
                    Console.WriteLine("Match: {0}", m.Value);
                    Console.WriteLine("Group 1: " + m.Groups[1].Value);
                    Console.WriteLine("Group 2: " + m.Groups[2].Value);
                    Console.WriteLine("Group 3: " + m.Groups[3].Value);
                    
                    switch (m.Groups[2].Value)
                    {
                        case "*":
                        {
                            result = Double.Parse(m.Groups[1].Value) * Double.Parse(m.Groups[3].Value);
                            break;
                        }
                        case "/":
                        {
                            result = Double.Parse(m.Groups[1].Value) / Double.Parse(m.Groups[3].Value);
                            break;
                        }
                        case "+":
                        {
                            result = Double.Parse(m.Groups[1].Value) + Double.Parse(m.Groups[3].Value);
                            break;
                        }
                        case "-":
                        {
                            result = Double.Parse(m.Groups[1].Value) - Double.Parse(m.Groups[3].Value);
                            break;
                        }
                        default:
                            result = -1;
                            break;
                    }
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Input {0} failed.", input);
                }
            }
        }
    }
}
