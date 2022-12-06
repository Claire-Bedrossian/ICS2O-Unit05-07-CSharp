using System;
class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        // This function accepts user input
        double numN;
        Console.Write("This function calculates the sum of natural numbers. The formula is Sn = (n ÷ 2) x (n + 1).");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("Enter a number:");
        numN = Convert.ToDouble(Console.ReadLine());
        double sum = 0;
        double counter = 0;
        double loop = 0;

        for (loop = 0; loop < numN; loop++)
        {
            counter++;
            sum = sum + counter;
        }
        Console.WriteLine("");
        Console.Write("The sum is " + sum + ".");
        Console.WriteLine("");
        Console.Write("/Done");
    }
}