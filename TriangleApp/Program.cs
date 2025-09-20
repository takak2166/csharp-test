using TriangleApp;

if (args.Length != 3)
{
    Console.WriteLine("Error: Please provide exactly 3 natural numbers");
    Environment.Exit(1);
}

int a, b, c;
if (!int.TryParse(args[0], out a))
{
    Console.WriteLine("Error: Non-numeric string detected");
    Environment.Exit(1);
}

if (!int.TryParse(args[1], out b))
{
    Console.WriteLine("Error: Non-numeric string detected");
    Environment.Exit(1);
}

if (!int.TryParse(args[2], out c))
{
    Console.WriteLine("Error: Non-numeric string detected");
    Environment.Exit(1);
}

bool isValid = Triangle.IsValid(a, b, c);
Console.WriteLine(isValid ? "Yes" : "No");
