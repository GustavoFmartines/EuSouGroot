    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkGreen;

    Console.WriteLine("--- Chatbot com o Groot! ---");

    Console.ResetColor();

        string pergunta;

do
{
    Console.Write("\nPergunta: ");
    pergunta = Console.ReadLine()!;

    if (pergunta.ToLower() == "tchau")
    {
        Console.WriteLine("\n         Resposta: Eu sou Groot!");
    }
    else
    {
        Console.WriteLine("\n         Resposta: Eu sou Groot.");
    }

} while (pergunta.ToLower() != "tchau");
