using Rekenmachine.Calculators;

namespace Rekenmachine
{
    public class CalculatorFactory
    {
        public Calculator Resolve(Request request)
        {
            if (request.Operation == OperationType.product)
                return new ProductCalculator();
            if (request.Operation == OperationType.division)
                return new DivisionCalculator();
            return new AdditionCalculator();
        }

    }
}
