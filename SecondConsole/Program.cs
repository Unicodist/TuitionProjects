// 365,,, 366

// Each 4 years, except if the year is multiple of 100 (2100, 2200, 2300), Except if it's multiple of 400

// 2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028 .... (x2100x), 2104, 2108 .... 2400

Console.WriteLine("Enter a year: ");
int year = int.Parse(Console.ReadLine());

if(year % 4 == 0)
{
    if(year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            Console.WriteLine("It is a leap year");
        }
        {
            Console.WriteLine("It is not a leap year.")
        }
    }
    else
    {
        Console.WriteLine("It is a leap year.");
    }
}
else
{
    Console.WriteLine("It is not a leap year.");
}