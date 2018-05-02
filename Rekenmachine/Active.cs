using System;

namespace Rekenmachine
{
    class Active
    {
        public static bool KeepActive()
        {
            Console.WriteLine("New calculation? (yes/no)");
            string input = Console.ReadLine();
            if (input != null && input.ToLower() == "yes")
                return true;
            return false;
        }
    }
}