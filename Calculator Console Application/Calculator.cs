using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Console_Application
{
    class Calculator
    {
        public double Addition(double Num1, double Num2)
        {
            // Adds two parameters together
            double Value = Num1 + Num2;
            Program.PreviousResult = Value;

            return Value;
        }

        public double Subtract(double Num1, double Num2)
        {
            double Value = Num1 - Num2;
            Program.PreviousResult = Value;

            return Value;
        }

        public double Multiply(double Num1, double Num2)
        {
            double Value = Num1 * Num2;
            Program.PreviousResult = Value;

            return Value;
        }

        public double Divide(double Num1, double Num2)
        {
            double Value = Num1 / Num2;
            Program.PreviousResult = Value;

            return Value;
        }


    }
}
