using System;
using maytinh; // Reference đến DLL

namespace MayTinhConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter operation (+, -, *, /):");
                string op = Console.ReadLine();

                MayTinhCalculator calc = new MayTinhCalculator();
                calc.Number1 = num1;
                calc.Number2 = num2;
                calc.Operation = op;
                double result = calc.Calculate();

                Console.WriteLine("Result: " + result);
                Console.WriteLine("Cosmic Math by Long ");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
