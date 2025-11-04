using System;

namespace maytinh
{
    public class MayTinhCalculator
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Operation { get; set; } // +, -, *, /
        public double Result { get; private set; }

        public MayTinhCalculator()
        {
            Number1 = 0;
            Number2 = 0;
            Operation = "+";
            Result = 0;
        }

        public double Calculate()
        {
            double baseResult = 0;
            switch (Operation.ToLower())
            {
                case "+":
                    baseResult = Number1 + Number2;
                    break;
                case "-":
                    baseResult = Number1 - Number2;
                    break;
                case "*":
                    baseResult = Number1 * Number2;
                    break;
                case "/":
                    if (Number2 == 0) throw new Exception("Cannot divide by zero!");
                    baseResult = Number1 / Number2;
                    break;
                default:
                    throw new Exception("Invalid operation! Use +, -, *, /");
            }

            // Dấu ấn cá nhân: Cosmic multiplier 
            Random rnd = new Random();
            double cosmicMultiplier = 1.0 + (rnd.NextDouble() * 0.5); // 1.0 to 1.5
            Result = baseResult * cosmicMultiplier;

            return Result; // Cosmic Math by [Long] 
        }
    }
}
