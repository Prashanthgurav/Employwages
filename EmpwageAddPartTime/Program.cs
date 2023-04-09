using System;

class Program
{
    static void Main(string[] args)
    {
        int IS_FULL_TIME = 1;
        int IS_PART_TIME = 2;
        int EMP_RATE_PER1_HOUR = 20;

        int emphrs = 0;
        int empwage = 0;
        Console.WriteLine("Welcome to Employee Wage Computation Problem");
        Random random = new Random();

        int empCheck = random.Next(0, 3);
        if (empCheck == IS_FULL_TIME)
        {
            emphrs = 8;
        }
        else if (empCheck == IS_PART_TIME)
        {
            emphrs = 4;
        }
        else
        {
            emphrs = 0;
        }
        empwage = emphrs * EMP_RATE_PER1_HOUR;
        Console.WriteLine("Emp Wage   " + empwage);

    }
}