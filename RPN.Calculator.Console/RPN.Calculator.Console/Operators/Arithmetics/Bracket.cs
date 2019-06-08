namespace RPN.Calculator.Console.Operators.Arithmetics
{
    using Interfaces;

    public class Bracket : IOperator
    {
        public Bracket()
        {
            Priority = 1;
            Symbol = "(";
        }

        public int Priority { get; set; } 
        public string Symbol { get; set; }
    }
}
