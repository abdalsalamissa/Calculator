using System;

namespace Calculator
{
    public class Calculator
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Calculator(double x,double y) 
        {
            X = x;
            Y = y;
        }
        public double Add() { return X + Y; }
        public double Subtract() { return X - Y; }
        public double Multiply() { return X * Y; }
        public string Divide() 
        {
            if (Y == 0)
            {
                return "Cannot divide by zero";
            }
            return (X / Y).ToString();
        }

    }
    
    class Calculator2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            double y = double.Parse(Console.ReadLine());

            Calculator calculator = new Calculator(x,y);
            Console.WriteLine("Select An Operation:");
            Console.WriteLine("(+) Addition");
            Console.WriteLine("(-) Subtraction");
            Console.WriteLine("(*) Multipliction");
            Console.WriteLine("(/) division");
            char operation = char.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+': Console.WriteLine($"Sum ({x} + {y}): {calculator.Add()}");
                    break;
                case '-':
                    Console.WriteLine($"Difference ({x} - {y}): {calculator.Subtract()}");
                    break;
                case '*':
                    Console.WriteLine($"Product ({x} * {y}): {calculator.Multiply()}");
                    break;
                case '/':
                    Console.WriteLine($"Quotient ({x} / {y}): {calculator.Divide()}");
                    break;
                default: Console.WriteLine("Invalid operation. Please select +, -, *, or /.");
                    break;
            }

        }
    }

}