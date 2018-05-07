namespace Rekenmachine.Calculators
{
    public class AdditionCalculator : Calculator
    {
        public override decimal Calculate(Request request)
        {
            return request.LeftHand + request.RightHand;
        }
    }
}
