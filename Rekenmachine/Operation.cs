using System;

namespace Rekenmachine
{
    class Operation 
    {
        public static int Calculate(string calculationString)
        {            
            string _operator = Operator.GetOperator(calculationString);
            if (_operator == "+")
            {
                int _indexOperator = calculationString.IndexOf("+");                
                int[] termArray = ParseString(calculationString, _indexOperator);
                return termArray[0] + termArray[1];
                
            }
            else if (_operator == "-")
            {
                return MarksBerekening(calculationString);
            }
            else if (_operator == "*")
            {
                int _indexOperator = calculationString.IndexOf("*");
                int[] termArray = ParseString(calculationString, _indexOperator);
                return termArray[0] * termArray[1];
            }
            else if (_operator == "/")
            {
                int _indexOperator = calculationString.IndexOf("/");
                int[] termArray = ParseString(calculationString, _indexOperator);
                return termArray[0] / termArray[1];
            }
            else
            {
                return 1000; // how do I solve this?
            }
        }

        private static int MarksBerekening(string calculationString)
        {
            int indexOperator = calculationString.IndexOf("-");
            int[] termArray = ParseString(calculationString, indexOperator);
            return termArray[0] - termArray[1];
        }

        public static int[] ParseString(string calculationString, int indexOperator)
        {
            int _indexOperator = indexOperator;
            string _firstStringTerm = calculationString.Substring(0, _indexOperator);
            string _secondStringTerm = calculationString.Substring(_indexOperator + 1);
            int _firstIntegerTerm = Int32.Parse(_firstStringTerm);
            int _secondIntegerTerm = Int32.Parse(_secondStringTerm);
            int[] termArray = { _firstIntegerTerm, _secondIntegerTerm };
            return termArray;
        }
    }
}
