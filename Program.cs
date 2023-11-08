//***********************************
// Student Name : Mohammad Ali Amirkhani
// Lesson Name : Advanced Programming (1)
// Practice Number : 5
//***********************************
using System.Numerics;

while (true)
{
    Console.Write("Please enter the factorial number: ");
    string Input = Console.ReadLine();
    int Number = 1;
    if (IsInt(Input))
    {
        Number = Convert.ToInt32(Input);
    }
    else
    {
        Console.WriteLine("Please enter a correct number!!!!");
        continue;
    }
    BigInteger Result = 1;
    for (int i = 1; i <= Number; i++)
    {
        Result *= i;
    }
    Console.WriteLine(Result);
    Console.Write("Do you want to continue?if yes enter (y): ");
    if (Console.ReadLine() == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}

static bool IsInt(string input)
{
    foreach (char c in input)
    {
        if (!Char.IsDigit(c))
        {
            return false;
        }
    }
    return true;
}