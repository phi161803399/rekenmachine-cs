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

        public Request(string input)
        {
            RequestAsString = input;
            Parse();
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

        private void Parse()
        {
            string matchPattern = @"^([0-9]+)([*\/+-])([\.\s\(\)0-9*\/+-]*)";
            string endPattern = @"^([0-9]*)$";
            var y = Regex.Match(this.RequestAsString, endPattern);
            if (y.Success)
            {
                this.Val = decimal.Parse(y.Groups[1].ToString());
            }

            var x = Regex.Match(RequestAsString, matchPattern);
            if (x.Success)
            {
                LeftHand = new Request(x.Groups[1].ToString());
                Operation = GetOperator(x.Groups[2].ToString());
                RightHand = new Request(x.Groups[3].ToString());
            }
        }
    }
}