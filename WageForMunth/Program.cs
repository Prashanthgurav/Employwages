using System;
using System.Diagnostics;

class WageForounth
{
    static void Main(string[] args)
    {

        const int isFullTime = 1;
        const int isPartTime = 2;
        const int NUMBER_OF_WORKING_DAY = 30;
        int EMP_RATE_PER1_HOUR = 20;
        int totalWage = 0;
        int day = 0;
        int empHrs = 0;
        int empWage = 0;

        Console.WriteLine("Welcome to Employee Wage Computation Promblem");
        Random random = new Random();
        for (day = 1; day <= NUMBER_OF_WORKING_DAY; day++)
        {
            int empAttendance = random.Next(0, 3);
            switch (empAttendance)
            {
                case isFullTime:
                    empHrs = 8;
                    break;

                case isPartTime:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0;
                    break;
            }


            empWage = empHrs * EMP_RATE_PER1_HOUR;
            Console.WriteLine("Employee Wage is:  " + empWage);
            totalWage += empWage;
        }
        Console.ReadLine();
    }
}