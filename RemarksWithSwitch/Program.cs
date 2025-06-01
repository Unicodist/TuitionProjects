// Write a program to print remarks message based on grade.

/*
 * If Grade is A, Print "Excellent"
 * If Grade is B, Print "Good"
 * If Grade is C, Print "Average"
 * If Grade is D, Print "Poor"
 * If Grade is E, Print "Failed"
 */

Console.WriteLine("Enter the grade:");
string grade = Console.ReadLine();

switch (grade)
{
    case "A":
        Console.WriteLine("Excellent");
        break;
    case "B":
        Console.WriteLine("Good");
        break;
    case "C":
        Console.WriteLine("Average");
        break;
    case "D":
        Console.WriteLine("Poor");
        break;
    case "E":
        Console.WriteLine("Failed");
        break;
}
