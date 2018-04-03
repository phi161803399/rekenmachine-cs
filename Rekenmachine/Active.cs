using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class Active
    {
        static bool KeepActive()
        {
            Console.Write("New calculation? (yes/no)");
            string input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                return true;
            }
            else if (input.ToLower() == "no")
            {
                return false;
            }
        }
    }
}