namespace RPN.Calculator.Console.Interfaces
{
    public interface IFunctionOperator : IOperator
    {
        int Priority { get; set; }
        string Symbol { get; set; }

        double Calculate(double value);
    }
}
