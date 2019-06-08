namespace RPN.Calculator.Console.Operators.Arithmetics
{
    using Interfaces;

    public class Remainder : IArithmeticOperator
    {
        /// <summary>
        /// '%' /Remainder operator/
        /// </summary>
        public Remainder()
        {
            Priority = 2;
            Symbol = "%";
        }

        public int Priority { get; set; }
        public string Symbol { get; set; }

        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        /// <returns>
        /// Return remainder after dividing its first operand by its second operand.
        /// </returns>
        public double Calculate(double a, double b)
        {
            return a % b;
        }
    }
}
