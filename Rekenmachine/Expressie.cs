using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Rekenmachine
{
    public class Request 
    {
        
        #region props
        public int LeftHand { get; set; }
        public int RightHand { get; set; }
        public OperationType Operation { get; set; }
        #endregion
        public Request(string input)
        {
            string pattern = @"(-?[0-9]+)\s*([*\/+-])\s*(-?[0-9]+)";
            var x = Regex.Match(input, pattern);
            if (!x.Success)
                return;
            
            LeftHand = Int32.Parse(x.Groups[1].ToString());
            RightHand = Int32.Parse(x.Groups[3].ToString());
            Operation = GetOperator(x.Groups[2].ToString());
        }
       
        private OperationType GetOperator(string op)
        {
            switch (op)
            {
                case "*":
                    return OperationType.product;
                case "/":
                    return OperationType.division;
                case "+":
                    return OperationType.addition;
                case "-":
                    return OperationType.subtraction;
            }

            return OperationType.addition;
        }



        public int Calc()
        {
            switch (Operation)
            {
                case OperationType.addition:
                {
                    Calculator cal = new AdditionCalculator();
                    return cal.Calculate();
                }
                case OperationType.division:
                {
                    Calculator cal = new DivisionCalculator();
                    return cal.Calculate();
                }
                case OperationType.product:
                {
                    Calculator cal = new ProductCalculator();
                    return cal.Calculate();
                }
                case OperationType.subtraction:
                {
                    Calculator cal = new SubtractionCalculator();
                    return cal.Calculate();
                }
                default:
                {
                    Calculator cal = new AdditionCalculator();
                    return cal.Calculate();
                }
            }
        }

        #region enum
        public enum OperationType
        {
            product = 1, division = 2, addition = 3, subtraction = 4
        }
        #endregion
    }

}