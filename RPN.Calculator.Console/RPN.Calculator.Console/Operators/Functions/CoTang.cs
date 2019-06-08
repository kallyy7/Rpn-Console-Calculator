namespace RPN.Calculator.Console.Operators.Functions
{
    using Interfaces;
    using System;

    public class CoTang : IFunctionOperator
    {
        /// <summary>
        /// CoTang(number) /The CoTangent function/
        /// </summary>
        public CoTang()
        {
            Priority = 4;
            Symbol = "cotang";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>Returns the cotangent of the specified angle.</returns>
        public double Calculate(double value)
        {
            return 1 / Math.Tan(value);
        }
    }
}
