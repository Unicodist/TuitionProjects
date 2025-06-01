// Write a program to take input as meter and print it as centimeter using function

Console.WriteLine("Enter length in meter");
int meter = int.Parse(Console.ReadLine());
int centimeter = ToCentimeter(meter);

Console.WriteLine($"{meter}m is {centimeter}cm");

int ToCentimeter(int lengthAsMeter)
{
    return lengthAsMeter * 100;
}

void PrintMessage(string message)
{
    Console.WriteLine(message);
}
