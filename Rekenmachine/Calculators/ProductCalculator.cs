﻿namespace Rekenmachine.Calculators
{
    public class ProductCalculator : Calculator
    {
        public override decimal Calculate(Request request)
        {
            return request.LeftHand * request.RightHand;
        }
    }
}