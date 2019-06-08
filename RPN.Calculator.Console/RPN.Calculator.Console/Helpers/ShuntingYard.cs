namespace RPN.Calculator.Console.Helpers
{
    using Interfaces;
    using Operators.Arithmetics;
    using Operators.Functions;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Convert from infix to postfix with Shunting Yard Algorithm
    /// </summary>
    public static class ShuntingYard
    {
        private static Stack<IOperator> operators = new Stack<IOperator>();
        private static Queue<string> result = new Queue<string>();

        public static List<string> Convert(string input)
        {
            string trimmedInput = input.Replace(" ", string.Empty);
            List<string> expression = SeparateTokens(trimmedInput);

            for (int i = 0; i < expression.Count; i++)
            {
                string currentToken = expression[i];
                double number = 0.0;

                if (double.TryParse(currentToken, out number)) // number
                {
                    result.Enqueue(number.ToString());
                }
                else if (OperationsCollection.Functions.Contains(currentToken)) // function
                {
                    IFunctionOperator op = null;

                    switch (currentToken.ToLower())
                    {
                        case "sqrt":
                            op = new Sqrt();
                            break;
                        case "sin":
                            op = new Sin();
                            break;
                        case "cos":
                            op = new Cos();
                            break;
                        case "tang":
                        case "tg":
                            op = new Tang();
                            break;
                        case "cotang":
                        case "ctg":
                            op = new CoTang();
                            break;
                    }

                    operators.Push(op);
                }
                else if (OperationsCollection.Arithmetics.Contains(currentToken)) // operator
                {
                    IArithmeticOperator op = null;

                    switch (currentToken.ToLower())
                    {
                        case "+":
                            op = new Plus();
                            break;
                        case "-":
                            op = new Minus();
                            break;
                        case "*":
                            op = new Multiplication();
                            break;
                        case "/":
                            op = new Division();
                            break;
                        case "%":
                            op = new Remainder();
                            break;
                        case "^":
                            op = new Pow();
                            break;
                    }

                    while (operators.Count > 0 &&
                        (OperationsCollection.Arithmetics.Contains(operators.Peek().Symbol) ||
                        OperationsCollection.Functions.Contains(operators.Peek().Symbol)) &&
                        op.Priority <= operators.Peek().Priority)
                    {
                        result.Enqueue(operators.Pop().Symbol);
                    }
                    operators.Push(op);

                }
                else if (currentToken == ",")
                {
                    foreach (var op in operators)
                    {
                        if (!op.Symbol.Contains("("))
                        {
                            throw new ArgumentException("Invalid brackets ot function separator");
                        }
                    }

                    while (operators.Peek().Symbol != "(")
                    {
                        result.Enqueue(operators.Pop().Symbol);
                    }
                }
                else if (currentToken == "(") // left bracket
                {
                    Bracket bracket = new Bracket();
                    operators.Push(bracket);
                }
                else if (currentToken == ")") // right bracket
                {
                    try
                    {
                        while (operators.Peek().Symbol != "(")
                        {
                            result.Enqueue(operators.Pop().Symbol);
                        }

                        operators.Pop();

                        if (OperationsCollection.Arithmetics.Contains(operators.Peek().Symbol))
                        {
                            result.Enqueue(operators.Pop().Symbol);
                        }
                    }
                    catch
                    {
                        throw new ArgumentException("Invalid brackets ot function separator");
                    }
                }
            }

            while (operators.Count > 0)
            {
                result.Enqueue(operators.Pop().Symbol);
            }
            return result.ToList();
        }

        /// <summary>
        /// Separate the tokens from input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static List<string> SeparateTokens(string input)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i])) //digit
                {
                    string number = string.Empty;

                    while (i < input.Length && (char.IsDigit(input[i]) || input[i] == '.'))
                    {
                        number += input[i];
                        i++;
                    }
                    result.Add(number);
                }

                if (i < input.Length && char.IsLetter(input[i])) //function
                {
                    string func = string.Empty;

                    while (i < input.Length && input[i] != '(')
                    {
                        func += input[i];
                        i++;
                    }

                    if (OperationsCollection.Functions.Contains(func.ToLower()))
                    {
                        result.Add(func);
                    }
                    else
                    {
                        Console.WriteLine(
                            $"The expression {func} is not correct or available!\r\n" +
                            $"Please, try again");

                        while (!OperationsCollection.Functions.Contains(func.ToLower()))
                        {
                            Console.WriteLine("Available Functions: ");
                            Console.WriteLine(string.Join(", ", OperationsCollection.Functions));

                            func = Console.ReadLine();
                        }

                        result.Add(func);
                    }
                }

                if (i < input.Length && (OperationsCollection.Arithmetics.Contains((input[i].ToString())) ||
                    input[i] == '(' ||
                    input[i] == ')')) //operator or bracket
                {
                    result.Add(input[i].ToString());
                }
            }

            return result;
        }
    }
}
