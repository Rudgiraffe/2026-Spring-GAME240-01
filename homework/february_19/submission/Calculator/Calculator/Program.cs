

Console.WriteLine("Hi, I'm a Calculator. What function would you like to do?");
Console.WriteLine("A. Addition");
Console.WriteLine("B. Subtraction");
Console.WriteLine("C. Multiplication");
Console.WriteLine("D. Division");
string function = Console.ReadLine();

Console.WriteLine("What's your first number?");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("What's your second number?");
double b = double.Parse(Console.ReadLine());

if (function == "A" || function == "a")
{
    Console.WriteLine(a + b);
}

if (function == "B" || function == "b")
{
    Console.WriteLine(a - b);
}

if (function == "C" || function == "c")
{
    Console.WriteLine(a * b);
}

if (function == "D" || function == "d")
{
    Console.WriteLine(a / b);
}