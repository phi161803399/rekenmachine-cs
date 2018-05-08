using System;
using System.Text.RegularExpressions;

namespace Rekenmachine
{
    public class Request 
    {
        public decimal LeftHand { get; set; }
        public decimal RightHand { get; set; }
        public OperationType Operation { get; set; }

        public Request(string input)
        {
            Parse(input);
        }

        public decimal Calculate()
        {
            var calculatorFactory = new CalculatorFactory();
            var calculator = calculatorFactory.Resolve(this);
            return calculator.Calculate(this);
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
        private void Parse(string input)
        {
            string pattern = @"(-?[0-9]+)\s*([*\/+-])\s*(-?[0-9]+)";
            var x = Regex.Match(input, pattern);
            if (!x.Success)
                return;

            LeftHand = Decimal.TryParse(x.Groups[1].ToString(), out decimal leftNumber) ? leftNumber : throw new Exception("Can't Parse LeftHand");
            RightHand = Decimal.TryParse(x.Groups[3].ToString(), out decimal rightNumber) ? rightNumber : throw new Exception("Can't Parse RightHand");
            
            Operation = GetOperator(x.Groups[2].ToString());
        }
    }
    
    public class MyTests
    {
        public bool TestEmptyInputShouldFailElegantly()
        {
            Request req = new Request("3*");
            return (req.Calculate() == 6);
        }
    }
}