using System;
using System.CodeDom;
using System.Text.RegularExpressions;

namespace Rekenmachine
{
    public class Request 
    {
        public Decimal LeftHand { get; set; }
        public Decimal RightHand { get; set; }
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
            string pattern = @"^(-?[0-9]+.?[0-9]*)\s*([*\/+-])\s*(-?[0-9]+.?[0-9]*)$";
            var x = Regex.Match(input, pattern);
            if (!x.Success)
                return;


            LeftHand = Decimal.TryParse(x.Groups[1].ToString(), out decimal leftNumber) 
                ? leftNumber 
                : throw new Exception("Can't Parse LeftHand");
            RightHand = Decimal.TryParse(x.Groups[3].ToString(), out decimal rightNumber) 
                ? rightNumber 
                : throw new Exception("Can't Parse RightHand");
            
            Operation = GetOperator(x.Groups[2].ToString());
        }
    }

    public class expr
    {
        private decimal? _val;
        public expr leftHand { get; set; }
        public expr rightHand { get; set; }
        public OperationType Operation { get; set; }

        public decimal val
        {
            get
            {
                if (_val.HasValue)
                    return _val;
                else
                {
                    doCalc();
                }
            }
            set => _val = value;
        }

        private void doCalc()
        {
            throw new NotImplementedException();
        }

        public expr()
        {
            
            var x = new expr();
            var y = new expr();
            var z = new expr();
            var q = new expr();

            q.leftHand = y;
            q.rightHand = z;
            z.leftHand = x;
            x.val = 17;
            //z.rightHand = 17;

            // 7*5*4
            // a.lefthand = 7
            // a.operator = *
            // a.righthand = b
            // b.lefthand = 5
            // b.operator = *
            // b.righthand = 4

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
            var matchPattern = /[^\s()*%/ +-]+/ g;
            var splitPattern = /[\s() *%/ +-] +/ g;

            document.write(str.match(matchPattern));
            document.write("<br />");
            document.write(str.split(splitPattern));
                </ script >
             *
             */
            string s = new string();
            s.Split()

            Console.Write(q.rightHand.leftHand.val);


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