namespace Rekenmachine
{
    class Operator
    {
        public static string GetOperator(string calculationString)
        {
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
    }
}
