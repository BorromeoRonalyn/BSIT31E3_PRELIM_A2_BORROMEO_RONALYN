while (true)
{
    Console.Write("Enter first number (or 'exit' to quit): ");
    string input = Console.ReadLine();
    if (input.ToLower() == "exit") break;

    while (true)
    {
        Console.Write("Enter first number (or 'exit' to quit): ");
        string input = Console.ReadLine();
        if (input.ToLower() == "exit") break;

        double num1 = Convert.ToDouble(input);
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operator: ");
        string op = Console.ReadLine();

        double result = 0;
        if (op == "+") result = num1 + num2;
        else if (op == "-") result = num1 - num2;
        else if (op == "*") result = num1 * num2;
        else if (op == "/") result = num1 / num2;

        Console.WriteLine("Result: " + result);
    }
}