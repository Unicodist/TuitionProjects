int length = TakeInput("Enter length for the first rectangle:");
int width = TakeInput("Enter width for the first rectangle:");

int length2 = TakeInput("Enter length for the second rectangle:");
int width2 = TakeInput("Enter width for the second rectangle:");

int area1 = GetArea(length, width);
int area2 = GetArea(length2, width2);

Console.WriteLine($"Area for first rectangle is: {area1}");

Console.WriteLine($"Area for second rectangle is: {area2}");

int TakeInput(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetArea(int length, int width)
{
    return length * width;
}

