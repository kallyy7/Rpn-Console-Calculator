namespace RPN.Calculator.Console.Helpers
{
    using Interfaces;
    using Operators.Arithmetics;
    using Operators.Functions;
    using System;
    using System.Collections.Generic;

    public static class RpnAlgorithm
    {
        public static double Calculate(List<string> input)
        {
            Stack<double> numbers = new Stack<double>();
            double value = 0.0;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i][0] >= '0' && input[i][0] <= '9')
                {
                    numbers.Push(double.Parse(input[i]));
                }
                else if (OperationsCollection.Arithmetics.Contains(input[i]))
                {
                    IArithmeticOperator arithmeticOperator = null;
                    value = numbers.Pop();
                    double secValue = numbers.Pop();
                    double result = 0.0;

                    switch (input[i])
                    {
                        case "+":
                            arithmeticOperator = new Plus();
                            result = arithmeticOperator.Calculate(secValue, value);
                            break;
                        case "-":
                            arithmeticOperator = new Minus();
                            result = (arithmeticOperator.Calculate(secValue, value));
                            break;
                        case "*":
                            arithmeticOperator = new Multiplication();
                            result = arithmeticOperator.Calculate(secValue, value);
                            break;
                        case "/":
                            arithmeticOperator = new Division();
                            result = arithmeticOperator.Calculate(secValue, value);
                            break;
                        case "%":
                            arithmeticOperator = new Remainder();
                            result = arithmeticOperator.Calculate(secValue, value);
                            break;
                        case "^":
                            arithmeticOperator = new Pow();
                            result = arithmeticOperator.Calculate(secValue, value);
                            break; ;
                    }

                        numbers.Push(result);
                }
                else if (OperationsCollection.Functions.Contains(input[i]))
                {
                    IFunctionOperator functionOperator = null;
                    value = numbers.Pop();

                    switch (input[i])
                    {
                        case "sin":
                            functionOperator = new Sin();
                            break;
                        case "cos":
                            functionOperator = new Cos();
                            break;
                        case "tang":
                            functionOperator = new Tang();
                            break;
                        case "cotang":
                            functionOperator = new CoTang();
                            break;
                        case "sqrt":
                            functionOperator = new Sqrt();
                            break;
                        case "ln":
                            numbers.Push(Math.Log(value));
                            break;
                        case "log":
                            numbers.Push(Math.Log10(value));
                            break;
                    }

                    if (functionOperator != null)
                    {
                        double result = functionOperator.Calculate(value);

                        numbers.Push(result);
                    }
                }
            }

            return numbers.Pop();
        }
    }
}