


Console.WriteLine("\n\tSeja bem vindo!\n\tVamos calcular? :)");
void DrawLine()
{
    Console.WriteLine("-----------------------------------");
}

int num2 = 0;
int answer = 0;

while (true)
{
    DrawLine();
    Console.WriteLine("Escolha a operação matemática:");
    DrawLine();
    Console.WriteLine("\tAdição (+)\n\tSubtração (-)\n\tMultiplicação (*)\n\tDivisão (/)");
    DrawLine();
    Console.WriteLine("Digite o símbolo correspondente.");
    DrawLine();

    var num1 = answer;
    string mathOperation = "null";

    switch (Console.ReadLine())
    {
        case "+":
            mathOperation = "+";
            DrawLine();
            Console.WriteLine("\tAdição escolhida!");
            DrawLine();
            break;
        case "-":
            mathOperation = "-";
            DrawLine();
            Console.WriteLine("\tSubtração escolhida!");
            DrawLine();
            break;
        case "*":
            mathOperation = "*";
            DrawLine();
            Console.WriteLine("\tMultiplicação escolhida!");
            DrawLine();
            break;
        case "/":
            mathOperation = "/";
            DrawLine();
            Console.WriteLine("\tDivisão escolhida!");
            DrawLine();
            break;
        default:
            DrawLine();
            Console.WriteLine("\tSímbolo não suportado.\n\tTente novamente!");
            DrawLine();
            continue;
    }

    if (num1 == 0)
    {
        DrawLine();
        Console.WriteLine("Digite o primeiro número.");
        DrawLine();
        while (int.TryParse(Console.ReadLine(), out int getNumber1))
        {
            DrawLine();
            Console.WriteLine($"\tNúmero selecionado: {getNumber1}");
            DrawLine();
            num1 = getNumber1;
            break;
        }
    }

    DrawLine();
    Console.WriteLine("Digite o próximo número.");
    DrawLine();
    while (int.TryParse(Console.ReadLine(), out int getNumber2))
    {
        DrawLine();
        Console.WriteLine($"\tNúmero selecionado: {getNumber2}");
        DrawLine();
        num2 = getNumber2;
        break;
    }

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
                DrawLine();
                Console.WriteLine("\tImpossível dividir por zero! :(\n\tReiniciando...");
                DrawLine();
                continue;
            }
            else
            {
                answer = (num1 / num2);
                break;
            }

    }
    DrawLine();
    Console.WriteLine($"\tResultado: {answer}");
    DrawLine();
    DrawLine();
    Console.WriteLine("Continuar a operação? (S ou N).");
    DrawLine();

    switch (Console.ReadLine()?.ToLower())
    {
        case "s":
            DrawLine();
            Console.WriteLine("Armazenando resultado...");
            DrawLine();
            continue;
        case "n":
            DrawLine();
            Console.WriteLine("Finalizando...");
            DrawLine();
            break;
    }
    break;

}