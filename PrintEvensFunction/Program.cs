//Write a program to take an input and print all of the even numbers until that input.

Console.WriteLine("Enter a number:");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number ; i++)
{
    if (IsEven(i))
    {
        Console.WriteLine($"Even: {i}");
    }
}

bool IsEven(int number) // returns true / false
{
    if(number %  2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}