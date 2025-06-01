/*
 * This tool should be able to perform following tasks.
 * Show current date and time
 * Say hello
 * Print 1 to 20
 * Exit
 */

/*
 * 1. Say hello
 * 2. Show current date
 * 3. Show current time
 * 4. Print 1 to 20
 * 5. Exit 
 */

Console.WriteLine("1. Say hello");
Console.WriteLine("2. Show current time");
Console.WriteLine("3. Show current date");
Console.WriteLine("4. Print 1 to 20");
Console.WriteLine("5. Exit");

int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Hello user!");
        break;
    case 2:
        ShowCurrentTime();
        break;
    case 3:
        ShowCurrentDate();
        break;
    case 4:
        PrintNumbers();
        break;
    default: 
        Console.WriteLine("Default choice");
        break;

}


void ShowCurrentTime()
{
    DateTime currentTime = DateTime.UtcNow;
    int hour = currentTime.Hour;

    if (hour > 12)
    {
        hour = hour - 12;
    }

    Console.WriteLine($"Current time: {hour}: {currentTime.Minute}");
}

void ShowCurrentDate()
{
    DateTime currentDate = DateTime.Now;
    int year = currentDate.Year;
    int month = currentDate.Month;
    int day = currentDate.Day;

    Console.WriteLine($"Current date: {year}/{month}/{day}");
}

void PrintNumbers()
{
    //Loop: Repeat something

    for (int i = 1;i <= 20; i++)
    {
        Console.WriteLine(i);
    }
}
