using System;
using System.Diagnostics;
using System.Security.AccessControl;

namespace Rekenmachine
{
    public class Operation 
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
            string _firstStringTerm = calculationString.Substring(0, indexOperator);
            string _secondStringTerm = calculationString.Substring(indexOperator + 1);
            int _firstIntegerTerm = Int32.Parse(_firstStringTerm);
            int _secondIntegerTerm = Int32.Parse(_secondStringTerm);
            int[] termArray = { _firstIntegerTerm, _secondIntegerTerm };
            return termArray;
        }
    }

    

    public class Calculation
    {
        public int LeftHand { get; set; }
        public int RightHand { get; set; }
        public OperationType Operation { get; set; }

        public int Calc(int number1, int number2)
        {
            switch (Operation)
            {
                case OperationType.addition:
                {
                    return number1 + number2;
                }
                case OperationType.division:
                {
                    return number1 / number2;
                }
                case OperationType.product:
                {
                    return number1 * number2;
                }
                case OperationType.subtraction:
                {
                    return number1 - number2;
                }
                default:
                {
                    return -1;
                }
            }
        }
    }

    public enum OperationType
    {
        product =1, division =2,addition =3, subtraction =4
    }
}
