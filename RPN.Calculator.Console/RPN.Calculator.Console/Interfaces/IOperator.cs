namespace RPN.Calculator.Console.Interfaces
{
    public interface IOperator
    {
        /// <summary>
        /// Operator precedence
        /// </summary>
        int Priority { set; get; }
        /// <summary>
        /// Operator symbol
        /// </summary>
        string Symbol { set; get; }
    }
}
