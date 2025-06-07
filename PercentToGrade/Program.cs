Console.WriteLine("Enter a percentage:");
decimal percentage = decimal.Parse(Console.ReadLine());

switch (percentage)
{
    case >= 90:
        Console.WriteLine("Excellent");
        break;
    case >= 70:
        Console.WriteLine("Very Good");
        break;
}