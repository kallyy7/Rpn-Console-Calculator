namespace RPN.Calculator.Console.Operators.Functions
{
    using Interfaces;
    using System;

    public class Sin : IFunctionOperator
    {
        /// <summary>
        /// Sin(number) /The Sine function/
        /// </summary>
        public Sin()
        {
            Priority = 4;
            Symbol = "sin";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <param name="value">An angle, measured in radians.</param>
        /// <returns>Returns the sine of the specified angle.</returns>
        public double Calculate(double value)
        {
            return Math.Sin(value);
        }
    }
}
