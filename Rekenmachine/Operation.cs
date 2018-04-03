using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class Operation
    {
        static public int Calculate(string calculationString)
        {
            string _operator = Operator.GetOperator(calculationString);
            if (_operator == "+")
            {
                int _indexOperator = calculationString.IndexOf("+");
                //Parse.ParseString(calculationString,_indexOperator);
                string _firstStringTerm = calculationString.Substring(0, _indexOperator);
                string _secondStringTerm = calculationString.Substring(_indexOperator + 1);
                int _firstIntegerTerm = Int32.Parse(_firstStringTerm);
                int _secondIntegerTerm = Int32.Parse(_secondStringTerm);
                return _firstIntegerTerm + _secondIntegerTerm;
            }
            else if (_operator == "-")
            {
                int _indexOperator = calculationString.IndexOf("-");
                string _firstStringTerm = calculationString.Substring(0, _indexOperator);
                string _secondStringTerm = calculationString.Substring(_indexOperator + 1);
                int _firstIntegerTerm = Int32.Parse(_firstStringTerm);
                int _secondIntegerTerm = Int32.Parse(_secondStringTerm);
                return _firstIntegerTerm - _secondIntegerTerm;
            }
            else if (_operator == "*")
            {
                int _indexOperator = calculationString.IndexOf("*");
                string _firstStringTerm = calculationString.Substring(0, _indexOperator);
                string _secondStringTerm = calculationString.Substring(_indexOperator + 1);
                int _firstIntegerTerm = Int32.Parse(_firstStringTerm);
                int _secondIntegerTerm = Int32.Parse(_secondStringTerm);
                return _firstIntegerTerm * _secondIntegerTerm;
            }
            else if (_operator == "/")
            {
                int _indexOperator = calculationString.IndexOf("/");
                string _firstStringTerm = calculationString.Substring(0, _indexOperator);
                string _secondStringTerm = calculationString.Substring(_indexOperator + 1);
                int _firstIntegerTerm = Int32.Parse(_firstStringTerm);
                int _secondIntegerTerm = Int32.Parse(_secondStringTerm);
                return _firstIntegerTerm / _secondIntegerTerm;
            }
            else
            {
                return 1000; // how do I solve this?
            }
        }        
    }
}
