using System;

class Program
{
    static void Main(string[] args)
    {
        int IS_FULL_TIME = 1;
        Console.WriteLine("Welcome to Employee Wage Computation Problem");
        Random random = new Random();

        int empCheck = random.Next(0, 2);
        if (empCheck == IS_FULL_TIME)
        {
            Console.WriteLine("Employ is present");
        }
        else
        {
            Console.WriteLine("Employ is absent");
        }
    }
}