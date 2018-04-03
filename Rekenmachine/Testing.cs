using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class Testing
    {
        static public bool OperatorPresent(string calculationString)
        {
            if (calculationString.Contains("+"))
            {
                return true;
            }
            else if (calculationString.Contains("-"))
            {
                return true;
            }
            else if (calculationString.Contains("*"))
            {
                return true;
            }
            else if (calculationString.Contains("/"))
            {
                return true;
            }
            else
                return false;
        }
    }
}
