namespace RPN.Calculator.Console
{
    using Helpers;
    using System;
    using System.Collections.Generic;

    public static class Calculator
    {
        public static void Start()
        {
            Console.WriteLine(
                "RPN Calculator\n" +
                "Convert the string using the Shunting Yard Algorithm " +
                "and calculate it with RPN Algorithm");

            while (true)
            {
                bool exit = false;

                Console.WriteLine(
                    "Choose option:\n" +
                    "1) Calculate and show result\n" +
                    "2) Show possible operations\n" +
                    "0) Quit");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();

                        Calculate();

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        ShowOperations();
                        Console.WriteLine("\nPress any key to continue");
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Press any key to quit");
                        Console.ReadKey();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("There is no such option");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();

                if (exit)
                    break;
            }
        }

        private static void Calculate()
        {
            Console.WriteLine("Enter expression to calculate:");
            string input = Console.ReadLine();

            List<string> convertFromInfixToPostfix = ShuntingYard.Convert(input);
            Console.WriteLine("\nExpression in postfix: {0}", string.Join(" ", convertFromInfixToPostfix));

            double result = RpnAlgorithm.Calculate(convertFromInfixToPostfix);
            Console.WriteLine("\nResult = {0}", result);
        }

        private static void ShowOperations()
        {
            Console.WriteLine("Calculator can do following:");
            Console.WriteLine("+  -  *  /");
            Console.WriteLine("x^y <- x power to y");
            Console.WriteLine("x%y <- x modulo y");
            Console.WriteLine("write 'pi' so it will be replaced to number");
            Console.WriteLine(
                "sin()\n" +
                "cos()\n" +
                "tg()\n" +
                "ctg()");
            Console.WriteLine(
                "log() <- logarithm base 10\n" +
                "logx() <- logarithm base x\n" +
                "ln() <- natural logarithm");
            Console.WriteLine(
                "sqrt() <- square root\n" +
                "rtx() <- root grade x");
        }
    }
}
