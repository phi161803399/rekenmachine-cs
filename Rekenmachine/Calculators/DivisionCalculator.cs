namespace Rekenmachine.Calculators
{
    public class DivisionCalculator : Calculator
    {
        public override decimal Calculate(Request request)
        {
            return request.LeftHand.Val / request.RightHand.Val;
        }
    }
}
