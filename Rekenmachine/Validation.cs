using System.Text.RegularExpressions;

namespace Rekenmachine
{
    class Validation
    {
        public static bool Validated(string input)
        {
            string pattern = @"(-?[0-9]+)\s*([*\/+-])\s*(-?[0-9]+)";
            Match m = Regex.Match(input, pattern);
            if (m.Success)
                return true;
            return false;
        }
    }
}
