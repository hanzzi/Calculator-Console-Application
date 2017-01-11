using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console_Application
{
    class Calculator
    {
        public double Calculate(double Num1, string Operator, double Num2)
        {
            if (Operator == "-" || Operator == "+" || Operator == "/" || Operator == "*")
            {
                switch (Operator)
                {
                    case "-":
                        return Num1 - Num2;

                    case "+":
                        return Num1 + Num2;

                    case "/":
                        return Num1 / Num2;

                    case "*":
                        return Num1 * Num2;
                    default:
                        Console.WriteLine("Error in Operator please check if you are using a correct operator");
                        break;
                }
            }
            return 0;
        }

        public double Addition(double Num1, double Num2)
        {
            // Adds two parameters together
            double Value = Num1 + Num2;

            return Value;
        }

        public double Subtract(double Num1, double Num2)
        {
            double Value = Num1 - Num2;

            return Value;
        }


    }
}
