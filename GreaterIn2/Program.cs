Console.WriteLine("Enter first number:");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
int second = int.Parse(Console.ReadLine());

if (first != second)
{
    if (first > second)
    {
        Console.WriteLine($"{first} is greater.");
    }
    else
    {
        Console.WriteLine($"{second} is greater.");
    }
}
else
{
    Console.WriteLine("They are the same numbers.");
}
