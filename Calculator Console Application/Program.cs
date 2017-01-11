using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Gets the first number
            Console.WriteLine("Please insert your first number");
            string Input1 = Console.ReadLine();
            double DInput1 = 0;
            if (Input1 != "ANS")
                double.TryParse(Input1, out DInput1);

            if (Input1 == "ANS")
                DInput1 = Program.PreviousResult;

            // Gets the Operator           
            Console.WriteLine("Please insert Operator (+, -, *, /, ^, sqrt, random)");
            string Operator = Console.ReadLine();
            double DInput2 = 0;

            if (Operator != "sqrt")
            {
                // Gets the second Number
                Console.WriteLine("Please Insert your second number");
                string Input2 = Console.ReadLine();
                if (Input2 != "ANS")
                    double.TryParse(Input2, out DInput2);
                if (Input2 == "ANS")
                    DInput2 = PreviousResult;
            }

            Program Prog = new Program();
            double Result = Prog.DetermineMethod(DInput1, Operator, DInput2);

            Console.WriteLine("Result");
            Console.WriteLine(Result);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Main(null);
        }

        public static double PreviousResult;

        public double DetermineMethod(double Num1, string Operator, double Num2)
        {
            // Opretter et nyt OBJEKT new Calculator == et OBJEKT
            AdvancedCalculator Calc = new AdvancedCalculator();

            if (Operator == "-" || Operator == "+" || Operator == "/" || Operator == "*" || Operator == "^" || Operator == "sqrt" || Operator == "random")
            {
                switch (Operator)
                {
                    case "-":
                        return Calc.Subtract(Num1, Num2);

                    case "+":
                        return Calc.Addition(Num1, Num2);

                    case "/":
                        return Calc.Divide(Num1, Num2);

                    case "*":
                        return Calc.Multiply(Num1, Num2);
                    case "^":
                        return Calc.Power(Num1, Num2);
                    case "sqrt":
                        return Calc.SquareRoot(Num1);
                    case "random":
                        return Calc.Random(Num1, Num2);
                    default:
                        Console.WriteLine("Error in Operator please check if you are using a correct operator");
                        break;
                }
            }
            return 0;
        }
    }
}

