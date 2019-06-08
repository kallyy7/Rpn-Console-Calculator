namespace RPN.Calculator.Console.Operators.Arithmetics
{
    using Interfaces;

    public class Minus : IArithmeticOperator
    {
        /// <summary>
        /// '-' /Minus operator/
        /// </summary>
        public Minus()
        {
            Priority = 1;
            Symbol = "-";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <summary>Subtract two numbers</summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>Return the subtraction of it's operands</returns>
        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
}
