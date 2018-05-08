using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    public class Splitting
    {
        public static void ToSplitAString()
        {
            string[] calcs = { "5 * 7   +3", "5 * 7+3", "5 * 7-4   +3" };
            char[] operatorChars = { '*', '/', '+', '-' };

            foreach (var calc in calcs)
            {
                System.Console.WriteLine($"Original calculation: '{calc}'");

                string[] operands = calc.Split(operatorChars);
                System.Console.WriteLine($"{operands.Length} operands in calculation:");

                foreach (var operand in operands)
                {
                    System.Console.WriteLine($"<{operand.Trim()}>");
                }
                System.Console.WriteLine("\n\n");
            }
        }
    }
}
