using System;

Console.WriteLine("\n\tWelcome!\n\tLet's do some math? :)");
void drawLine()
{
    Console.WriteLine("-----------------------------------");
}

int num1 = 0;
int num2 = 0;
int answer = 0;

while (true)
{
    drawLine();
    Console.WriteLine("Choose which math operation you want to perform:");
    drawLine();
    Console.WriteLine("\tAddition (+)\n\tSubtraction (-)\n\tMultiplication (*)\n\tDivision (/)");
    drawLine();
    Console.WriteLine("Type the desired math symbol.");
    drawLine();

    num1 = answer;
    string mathOperation = "null";

    switch (Console.ReadLine())
    {
        case "+":
            mathOperation = "+";
            drawLine();
            Console.WriteLine("\tChose addition!");
            drawLine();
            break;
        case "-":
            mathOperation = "-";
            drawLine();
            Console.WriteLine("\tChose subtraction!");
            drawLine();
            break;
        case "*":
            mathOperation = "*";
            drawLine();
            Console.WriteLine("\tChose multiplication!");
            drawLine();
            break;
        case "/":
            mathOperation = "/";
            drawLine();
            Console.WriteLine("\tChose division!");
            drawLine();
            break;
        default:
            drawLine();
            Console.WriteLine("\tSymbol not suported yet.\n\tTry again!");
            drawLine();
            continue;
    }

    if (num1 == 0)
    {
        drawLine();
        Console.WriteLine("Type the first number.");
        drawLine();
        while (int.TryParse(Console.ReadLine(), out int getNumber1))
        {
            drawLine();
            Console.WriteLine($"\tTyped number: {getNumber1}");
            drawLine();
            num1 = getNumber1;
            break;
        };
    }

    drawLine();
    Console.WriteLine("Type the next number.");
    drawLine();
    while (int.TryParse(Console.ReadLine(), out int getNumber2))
    {
        drawLine();
        Console.WriteLine($"\tTyped Number: {getNumber2}");
        drawLine();
        num2 = getNumber2;
        break;
    };

    Console.WriteLine($"----------- [ {num1} {mathOperation} {num2} ] -----------");
    switch (mathOperation)
    {
        case "+":
            answer = (num1 + num2);
            break;
        case "-":
            answer = (num1 - num2);
            break;
        case "*":
            answer = (num1 * num2);
            break;
        case "/":
            if ((num1 == 0) || (num2 == 0))
            {
                drawLine();
                Console.WriteLine("\tImpossible divide by zero! :(\n\tRestarting...");
                drawLine();
                continue;
            }
            else
            {
                answer = (num1 / num2);
                break;
            }

    }
    drawLine();
    Console.WriteLine($"\tResult: {answer}");
    drawLine();
    drawLine();
    Console.WriteLine("Continue the operation? (Y ou N).");
    drawLine();

    switch (Console.ReadLine()?.ToLower())
    {
        case "y":
            drawLine();
            Console.WriteLine("Storing results...");
            drawLine();
            continue;
        case "n":
            drawLine();
            Console.WriteLine("Finishing...");
            drawLine();
            break;
    }
    break;

}