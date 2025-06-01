// Void function -> Does something and doesn't return any value
// Return function -> Does something and returns a value at the end

// Write a function to find the grade if marks is provided

// Input number, output : Grade ( Excellent, Very Good, Good, Average, Lower )

/*
 * More than 80 => Excellent
 * 70 to 80 => Very Good
 * 50 to 70 => Good
 * 30 to 50 => Average
 * 0 - 30 => Lower
 */

Console.WriteLine("Enter marks for the first student");
int marks1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter marks for the second student");
int marks2 = int.Parse(Console.ReadLine());

string grade1 = GetGrade(marks1);
Console.WriteLine($"The grade for the first student is: {grade1}.");

string grade2 = GetGrade(marks2);
Console.WriteLine($"The grade for the second student is: {grade2}.");

string GetGrade(int marks)
{
    if (marks > 80)
    {
        return "Excellent";
    }

    if (marks > 70)
    {
        return "Very Good";
    }

    if (marks > 50)
    {
        return "Good";
    }

    if(marks > 30)
    {
        return "Average";
    }

    return "Lower";
}
