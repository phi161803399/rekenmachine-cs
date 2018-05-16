using System;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Rekenmachine
{
    public class Request
    {
        private decimal? _val;
        public Request LeftHand { get; set; }
        public Request RightHand { get; set; }
        public OperationType Operation { get; set; }
        public decimal Val
        {
            get
            {
                if (_val.HasValue)
                    return _val.Value;
                else
                {
                    return Calculate();
                }
            }
            set => _val = value;
        }

        public string RequestAsString { get; set; }

        public Request()
        {
            
        }

        public Request(string input)
        {
            RequestAsString = input;
            Parse(this);
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
        private void Parse(Request request)
        {
            string matchPattern = @"^(-?[0-9]+\.?[0-9]*)\s*([*\/+-])\s*([\.\s\(\)0-9*\/+-]*)";
            string endPattern = @"(-?[0-9]+\.?[0-9]+)";
            var x = Regex.Match(input, matchPattern);
            
            if (!x.Success)
                return;

            LeftHand.Val = decimal.Parse(x.Groups[1].ToString());
            Operation = GetOperator(x.Groups[2].ToString());
            var y = Regex.Match(x.Groups[3].ToString(), endPattern);
            if (y.Success)
            {
                RightHand.Val = decimal.Parse(x.Groups[3].ToString());
            }
            else
            {
                
            }
        }

        private Request Parse(string input, Request request)
        {
            
            string matchPattern = @"^(-?[0-9]+\.?[0-9]*)\s*([*\/+-])\s*([\.\s\(\)0-9*\/+-]*)";


            var x = Regex.Match(input, matchPattern);
            if (!x.Success)
                return new Request() { Val = decimal.Parse(x.Groups[2].ToString()) };

            var newRequest = new Request();
            LeftHand.Val = decimal.Parse(x.Groups[1].ToString());
            Operation = GetOperator(x.Groups[2].ToString());
            RightHand = Parse(x.Groups[3].ToString(), this);
            return newRequest;
        }

        /*
             * new a
             * a.lefthand = group[1]
             * a.operator = group[2]
             * new b
             * b.lefthand = group[3]
             * b.operator = group[4]
             * b.righthand= group[5]
             * a.righthand = b
             *
             *
             */

        /*
         * readword()
         * - int
         * - operator
         * - whitespace (trim)
         *
         * <script type="text/javascript">  
        var str = "Field1 * (Field2+ Field3) - Field4";   
        var matchPattern = /[^\s()*%\/ +-]+/ g;
        var splitPattern = /[\s() *%\/ +-] +/ g;

        document.write(str.match(matchPattern));
        document.write("<br />");
        document.write(str.split(splitPattern));
            </ script >
         *
         */

        /*
        string s = new string();
        s.Split()

        Console.Write(q.rightHand.leftHand.val);
        */
        public override string ToString()
        {
            return LeftHand.ToString() + Operation.ToString() + RightHand.ToString();
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