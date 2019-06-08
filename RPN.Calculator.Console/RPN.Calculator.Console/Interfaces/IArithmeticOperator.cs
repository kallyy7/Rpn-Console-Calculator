namespace RPN.Calculator.Console.Interfaces
{
    public interface IArithmeticOperator : IOperator
    {
        int Priority { get; set; }
     
        string Symbol { get; set; }

        double Calculate(double a, double b);
    }
}
