using System;

namespace BSIT31E3_PRELIM_H1_CALCULATOR_BORROMEO
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first number (or 'exit' to quit): ");
                string input = Console.ReadLine();

                // Check for exit condition
                if (input.ToLower() == "exit")
                {
                    break;
                }

                // Parse the first number
                double num1 = Convert.ToDouble(input);

                // Get second number and operator
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operator (+, -, *, /): ");
                string op = Console.ReadLine();

                // Perform the calculation
                double result = 0;
                if (op == "+")
                {
                    result = num1 + num2;
                }
                else if (op == "-")
                {
                    result = num1 - num2;
                }
                else if (op == "*")
                {
                    result = num1 * num2;
                }
                else if (op == "/")
                {
                    // Basic check to prevent division by zero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        continue;
                    }
                }

                // Display result
                Console.WriteLine("Result: " + result);
                Console.WriteLine(); // Blank line for readability
            }
        }
    }
}