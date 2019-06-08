using RPN.Calculator.Console.Interfaces;

namespace RPN.Calculator.Console.Operators.Functions
{
    using System;
    using Interfaces;

    public class Pow : IArithmeticOperator
    {
        /// <summary>
        /// Pow(number, power) /The Pow function/
        /// </summary>
        /// <param name="fnum">number to be raised to a power</param>
        /// <param name="snum">number that specifies a power</param>
        public Pow()
        {
            Priority = 3;
            Symbol = "^";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <param name="fnum">number to be raised to a power</param>
        /// <param name="snum">number that specifies a power</param>
        /// <returns>The number x raised to the power y.</returns>
        public double Calculate(double value, double value2)
        {
            return Math.Pow(value, value2);
        }
    }
}
