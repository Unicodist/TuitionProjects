/*
 * ___*
 * __**
 * _***
 * ****
 */

for(int i = 1; i<= 20; i++)
{
    for(int s = 1; s <= 20 - i; s++)
    {
        Console.Write(" ");
    }
    for(int j = 1; j<= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}