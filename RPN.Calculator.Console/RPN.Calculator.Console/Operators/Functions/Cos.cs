namespace RPN.Calculator.Console.Operators.Functions
{
    using Interfaces;
    using System;

    public class Cos : IFunctionOperator
    {
        /// <summary>
        /// Cos(number) /The Cosine function/
        /// </summary>
        public Cos()
        {
            Priority = 4;
            Symbol = "cos";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>Returns the cosine of the specified angle.</returns>
        public double Calculate(double value)
        {
            return Math.Cos(value);
        }
    }
}
