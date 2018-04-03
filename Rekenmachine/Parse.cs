using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    class Parse
    {
        static public void ParseString(string calculationString, int indexOperator)
        {
            int _indexOperator = indexOperator;
            string _firstStringTerm = calculationString.Substring(0, _indexOperator);
            string _secondStringTerm = calculationString.Substring(_indexOperator + 1);
            int _firstIntegerTerm = Int32.Parse(_firstStringTerm);
            int _secondIntegerTerm = Int32.Parse(_secondStringTerm);
        }
    }
}