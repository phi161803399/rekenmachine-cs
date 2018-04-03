using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class Active
    {
        public static bool KeepActive()
        {            
            Console.WriteLine("New calculation? (yes)");
            string input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                return true;
            }            
            else
            {
                return false;
            }
        }
    }
}