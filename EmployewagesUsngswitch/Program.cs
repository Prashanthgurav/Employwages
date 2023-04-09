using System;
using System.Diagnostics;

class Switchcase
{
    static void Main(string[] args)
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        int EMP_RATE_PER1_HOUR = 20;

        int emphrs = 0;
        int empwage = 0;
        Console.WriteLine("Welcome to Employee Wage Computation Problem");
        Random random = new Random();

        int empAttendance = random.Next(0, 3);
        switch (empAttendance)
        {
            case isFullTime:
                emphrs = 8;
                break;

            case isPartTime:
                emphrs = 8;
                break;

            default:
                emphrs = 0;
                break;
        }


        empwage = emphrs * EMP_RATE_PER1_HOUR;
        Console.WriteLine("Emp Wage   " + empwage);

    }
}