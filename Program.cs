using System;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###############################");
            Console.WriteLine("  This is a simple calculator");
            Console.WriteLine("###############################");
            Console.WriteLine("");


            string value;
            do
            {
                int res;
                int num1;
                while (true) {                     
                    Console.Write("Enter first number:");
                    string input = Console.ReadLine();
                                   
                    if (int.TryParse(input, out num1)){
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a number");
                    }
                }

                int num2;
                while (true)
                {
                    Console.Write("Enter second number:");
                    string input = Console.ReadLine();
                                   
                    if (int.TryParse(input, out num2))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a number");
                    }
                }

                Console.Write("Enter symbol(/,+,-,*):");

                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition:");
                        Console.WriteLine(num1 + "+" + num2 +"= " + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction:");
                        Console.WriteLine(num1 + "-" + num2 + "= " + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication:");
                        Console.WriteLine(num1 + "x" + num2 + "= " + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division:");
                        Console.WriteLine(num1 + "/" + num2 + "= " + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadLine();
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");
        }

    }
    
}
