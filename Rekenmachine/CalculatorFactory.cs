using Rekenmachine.Calculators;

namespace Rekenmachine
{
    public class CalculatorFactory
    {
        public Calculator Resolve(Request request)
        {
            if (request.Operation == OperationType.product)
                return new ProductCalculator();
            else if (request.Operation == OperationType.division)
                return new DivisionCalculator();
            else if (request.Operation == OperationType.subtraction)
                return new SubtractionCalculator();
            else
                return new AdditionCalculator();
        }
    }
}
