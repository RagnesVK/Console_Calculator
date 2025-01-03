using System;

Console.WriteLine("\n\tSeja bem vindo!\n\tVamos calcular? :)");
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
    Console.WriteLine("Escolha a operação matemática:");
    drawLine();
    Console.WriteLine("\tAdição (+)\n\tSubtração (-)\n\tMultiplicação (*)\n\tDivisão (/)");
    drawLine();
    Console.WriteLine("Digite o símbolo correspondente.");
    drawLine();

    num1 = answer;
    string mathOperation = "null";

    switch (Console.ReadLine())
    {
        case "+":
            mathOperation = "+";
            drawLine();
            Console.WriteLine("\tAdição escolhida!");
            drawLine();
            break;
        case "-":
            mathOperation = "-";
            drawLine();
            Console.WriteLine("\tSubtração escolhida!");
            drawLine();
            break;
        case "*":
            mathOperation = "*";
            drawLine();
            Console.WriteLine("\tMultiplicação escolhida!");
            drawLine();
            break;
        case "/":
            mathOperation = "/";
            drawLine();
            Console.WriteLine("\tDivisão escolhida!");
            drawLine();
            break;
        default:
            drawLine();
            Console.WriteLine("\tSímbolo não suportado.\n\tTente novamente!");
            drawLine();
            continue;
    }

    if (num1 == 0)
    {
        drawLine();
        Console.WriteLine("Digite o primeiro número.");
        drawLine();
        while (int.TryParse(Console.ReadLine(), out int getNumber1))
        {
            drawLine();
            Console.WriteLine($"\tNúmero selecionado: {getNumber1}");
            drawLine();
            num1 = getNumber1;
            break;
        };
    }

    drawLine();
    Console.WriteLine("Digite o próximo número.");
    drawLine();
    while (int.TryParse(Console.ReadLine(), out int getNumber2))
    {
        drawLine();
        Console.WriteLine($"\tNúmero selecionado: {getNumber2}");
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
                Console.WriteLine("\tImpossível dividir por zero! :(\n\tReiniciando...");
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
    Console.WriteLine($"\tResultado: {answer}");
    drawLine();
    drawLine();
    Console.WriteLine("Continuar a operação? (S ou N).");
    drawLine();

    switch (Console.ReadLine()?.ToLower())
    {
        case "s":
            drawLine();
            Console.WriteLine("Armazenando resultado...");
            drawLine();
            continue;
        case "n":
            drawLine();
            Console.WriteLine("Finalizando...");
            drawLine();
            break;
    }
    break;

}