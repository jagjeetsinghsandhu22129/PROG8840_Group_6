﻿using Calculator;

bool exit = false;

while (!exit)
{
    Prompts.PrintWelcomeMenu();
    Prompts.PrintOptions();
    Console.WriteLine("Enter operation number: ");
    string? OptionChoice = Console.ReadLine();

    if (OptionChoice == "5") // Exit option
    {
        exit = true;
        Console.WriteLine("Smoothly exiting the application.....");
        break;
    }

    // For square root, only one number is needed
    Console.WriteLine("Enter number 1: ");
    string? Number1 = Console.ReadLine();

    // Check for square root operation
    if (OptionChoice == "8") // Assuming 8 is the choice for square root
    {
        if (!float.TryParse(Number1, out float Number1Converted))
        {
            Console.WriteLine("Invalid number format. Please enter a valid number.");
            continue;
        }

        float SqrtResult = Evaluator.Eval("sqrt", Number1Converted);
        Console.WriteLine($"The square root of {Number1Converted} is {SqrtResult}");
    }
    else
    {
        Console.WriteLine("Enter number 2: ");
        string? Number2 = Console.ReadLine();

        if (!float.TryParse(Number1, out float Number1Converted) || !float.TryParse(Number2, out float Number2Converted))
        {
            Console.WriteLine("Invalid number format. Please enter valid numbers.");
            continue;
        }

        switch (OptionChoice)
        {
            case "1":
                float Sum = Evaluator.Eval("+", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} + {Number2Converted} = {Sum}");
                break;
            case "2":
                float Subtract = Evaluator.Eval("-", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} - {Number2Converted} = {Subtract}");
                break;
            case "3":
                float Product = Evaluator.Eval("*", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} * {Number2Converted} = {Product}");
                break;
            case "4":
                if (Number2Converted != 0)
                {
                    float Divide = Evaluator.Eval("/", Number1Converted, Number2Converted);
                    Console.WriteLine($"{Number1Converted} / {Number2Converted} = {Divide}");
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero. Please enter a valid number for the division.");
                }
                break;
            case "6":
                if (Number2Converted != 0)
                {
                    float Modulo = Evaluator.Eval("%", Number1Converted, Number2Converted);
                    Console.WriteLine($"{Number1Converted} % {Number2Converted} = {Modulo}");
                }
                else
                {
                    Console.WriteLine("Cannot modulo by zero. Please enter a valid number for the Modulo Operation.");
                }
                break;
            case "7":
                float Power = Evaluator.Eval("^", Number1Converted, Number2Converted);
                Console.WriteLine($"{Number1Converted} ^ {Number2Converted} = {Power}");
                break;
            default:
                Console.WriteLine("Unimplemented option. Please enter a valid option.");
                break;
        }
    }

    Console.WriteLine("Press Enter to continue .......");
    Console.ReadLine(); // Wait for user to press Enter before continuing
}
