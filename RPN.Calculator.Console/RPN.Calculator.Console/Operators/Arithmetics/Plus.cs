namespace RPN.Calculator.Console.Operators.Arithmetics
{
    using Interfaces;

    public class Plus : IArithmeticOperator
    {
        /// <summary>
        /// '+' /Plus operator/
        /// </summary>
        public Plus()
        {
            Priority = 1;
            Symbol = "+";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <summary>Sum two numbers</summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>Return the sum of it's operands</returns>
        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}
