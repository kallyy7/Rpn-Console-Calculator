namespace RPN.Calculator.Console.Operators.Arithmetics
{
    using Interfaces;
    using System;

    public class Division : IArithmeticOperator
    {
        /// <summary>
        /// '/' /Division operator/
        /// </summary>  
        public Division()
        {
            Priority = 2;
            Symbol = "/";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <summary>Divide two numbers</summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>  
        /// <exception cref="DivideByZeroException">
        /// In mathematics it is a rule that we cannot divide by zero, 
        /// because it contradicts the other rules of mathematics.
        /// </exception>
        /// <returns>Return the division of it's operands</returns>
        public double Calculate(double a, double b)
        {
            if (a == 0)
            {
                throw new DivideByZeroException(
                    "In mathematics it is a rule that we cannot divide by zero, " +
                    "because it contradicts the other rules of mathematics.");
            }

            return a / b;
        }
    }
}
