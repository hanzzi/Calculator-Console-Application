using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            double DInput1;
            double.TryParse(Input1, out DInput1);
            
            
            // Gets the Operator           
            Console.WriteLine("Please insert Operator");
            string Operator = Console.ReadLine();

            // Gets the second Number
            Console.WriteLine("Please Insert your second number");
            string Input2 = Console.ReadLine();
            double DInput2;
            double.TryParse(Input2, out DInput2);


            // Opretter et nyt OBJEKT new Calculator == et OBJEKT
            Calculator Calc = new Calculator();
            double Result = Calc.Calculate(DInput1, Operator, DInput2);

            Console.WriteLine("Result");
            Console.WriteLine(Result);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Main(null);

        }
    }
}
