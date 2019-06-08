namespace RPN.Calculator.Console.Operators.Functions
{
    using Interfaces;
    using System;

    public class Sqrt : IFunctionOperator
    {
        /// <summary>
        /// Sqrt(number) /The square root function/
        /// </summary>
        public Sqrt()
        {
            Priority = 4;
            Symbol = "sqrt";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <param name="value">The number whose square root is to be found.</param>
        /// <returns>Returns the square root of a specified number.</returns>
        public double Calculate(double value)
        {
            return Math.Sqrt(value);
        }
    }
}
