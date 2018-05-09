﻿namespace Rekenmachine.Calculators
{
    public class DivisionCalculator : Calculator
    {
        public override decimal Calculate(Request request)
        {
            return request.LeftHand.val / request.RightHand.val;
        }
    }
}
