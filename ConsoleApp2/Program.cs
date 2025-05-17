namespace ConsoleApp3;
class Calculator
{
    public int A{get;set;}
    public int B{get;set;}

    public Calculator(int a, int b)
    {
        A = a;
        B = b;
    }

    public override string ToString() =>@$"A:{A}
        B:{B}";

    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Modulo(int a, int b)
    {
        return a % b;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("a daxil edin :");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("b daxil edin :");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("1 ci Add\n 2 ci Sub \n 3 cu Multiple \n 4 cu Div \n 5 ci Mod  ");
        Console.WriteLine();
        Console.Write("Secim daxil edin :");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Calculator calculator = new Calculator(a, b);
        if (c == 1)
        {
            Console.WriteLine($"Addition: {calculator.Add(a, b)}");
        }
        else if (c == 2)
        {
            Console.WriteLine($"Subtraction: {calculator.Subtract(a, b)}");
        }
        else if (c == 3)
        {
            Console.WriteLine($"Multiplication: {calculator.Multiply(a, b)}");
        }
        else if (c == 4)
        {
            Console.WriteLine($"Division: {calculator.Divide(a, b)}");
        }
        else if (c == 5)
        {
            Console.WriteLine($"Modulo: {calculator.Modulo(a, b)}");
        }
        else
        {
            Console.WriteLine("Sehv secim elediniz ");
        }
    }
}