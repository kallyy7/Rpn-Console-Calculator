namespace RPN.Calculator.Console.Operators.Arithmetics
{
    using Interfaces;

    public class Multiplication : IArithmeticOperator
    {
        /// <summary>
        /// '*' /Multiplication operator/
        /// </summary>
        public Multiplication()
        {
            Priority = 2;
            Symbol = "*";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <summary>Multiply two numbers</summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>Return the multiplication of it's operands</returns>
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
}
