namespace Rekenmachine
{
    public abstract class Calculator
    {
        public Request Request { get; set; }
        public abstract int Calculate();
    }

    public class ProductCalculator : Calculator
    {
        public override int Calculate()
        {
            return Request.LeftHand * Request.RightHand;
        }
    }
    public class DivisionCalculator : Calculator
    {
        public override int Calculate()
        {
            return Request.LeftHand / Request.RightHand;
        }
    }
    public class AdditionCalculator : Calculator
    {
        public override int Calculate()
        {
            return Request.LeftHand + Request.RightHand;
        }
    }
    public class SubtractionCalculator : Calculator
    {
        public override int Calculate()
        {
            return Request.LeftHand - Request.RightHand;
        }
    }

}
