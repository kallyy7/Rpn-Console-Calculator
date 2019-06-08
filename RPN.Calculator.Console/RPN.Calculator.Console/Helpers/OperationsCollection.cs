namespace RPN.Calculator.Console.Helpers
{
    using System.Collections.Generic;
    /// <summary>
    /// Operations
    /// </summary>
    public static class OperationsCollection
    {
        // Arithmetic operators
        public static List<string> Arithmetics { get; }
            = new List<string>()
            {
                "+",
                "-",
                "*",
                "/",
                "^",
                "%"
            };

        // Functions
        public static List<string> Functions { get; }
            = new List<string>()
            {
                "sin",
                "cos",
                "tang",
                "cotang",
                "sqrt",
                "pow",
                "sqrt" };
    }
}
