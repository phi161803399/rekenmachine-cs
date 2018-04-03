using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class Operator
    {
        public static string GetOperator(string calculationString)
        {
            bool operatorPresent = Testing.OperatorPresent(calculationString);
            if (operatorPresent)
            {
                //Console.WriteLine("There is an operator");
                if (calculationString.Contains("+"))
                {
                    return "+";
                }
                else if (calculationString.Contains("-"))
                {
                    return "-";
                }
                else if (calculationString.Contains("*"))
                {
                    return "*";
                }
                else if (calculationString.Contains("/"))
                {
                    return "/";
                }
                else
                {
                    return "No valid operator";
                }
            }
            else
            {
                return "No valid operator";
            }
        }
    }
}
