/*
 * *****
 * ****
 * ***
 * **
 * *
 */

Console.WriteLine("Enter the number of rows:");
int rows = int.Parse(Console.ReadLine());

for(int i = rows; i >= 1; i--)
{
    for(int j = 1; j<=i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}