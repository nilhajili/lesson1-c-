int i = 0;
while (true)
{
    Console.WriteLine(DateTime.Now);
    Console.WriteLine("answer the questions 1-5:");
    Console.WriteLine(" 1+4=?");
    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 5)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The answer is 5,you answered true");
        Console.ResetColor();
        i++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The answer is 5,you answered false");
        Console.ResetColor();
    }
    Console.WriteLine(" 2*8=?");
    int answer1 = Convert.ToInt32(Console.ReadLine());
    if (answer1 == 16)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The answer is 16,you answered true");
        Console.ResetColor();
        i++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The answer is 16,you answered false");
        Console.ResetColor();
    }
    Console.WriteLine(" 5*5=?");
    int answer2 = Convert.ToInt32(Console.ReadLine());
    if (answer2 == 25)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The answer is 25,you answered true");
        Console.ResetColor();
        i++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The answer is 25,you answered false");
        Console.ResetColor();
    }
    Console.WriteLine(" 16*1=?");
    int answer3 = Convert.ToInt32(Console.ReadLine());
    if (answer3 == 16)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The answer is 16,you answered true");
        Console.ResetColor();
        i++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The answer is 16,you answered false");
        Console.ResetColor();
    }
    Console.WriteLine(" 25+4=?");
    int answer4 = Convert.ToInt32(Console.ReadLine());
    if (answer4 == 29)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The answer is 29,you answered true");
        Console.ResetColor();
        i++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The answer is 29,you answered false");
        Console.ResetColor();
    }
    break;
}
Console.WriteLine(DateTime.Now);
Console.WriteLine($"Your score:{i}");