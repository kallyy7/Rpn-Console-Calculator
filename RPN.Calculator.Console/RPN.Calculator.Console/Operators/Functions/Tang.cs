namespace RPN.Calculator.Console.Operators.Functions
{
    using Interfaces;
    using System;

    public class Tang : IFunctionOperator
    {
        /// <summary>
        /// Tang(number) /The Tangent function/
        /// </summary>
        public Tang()
        {
            Priority = 4;
            Symbol = "tang";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <param name="value"> An angle, measured in radians.</param>
        /// <returns>Returns the tangent of the specified angle.</returns>
        public double Calculate(double value)
        {
            return Math.Tan(value);
        }
    }
}
