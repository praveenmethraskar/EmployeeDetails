using System;

namespace EmployeeDetails
{
    public class program
    {




        public static void Main()
        {
            int Is_Full_Time = 1;
            int If_Part_Time = 2;
            int Wage_per_Hour = 20;
            int WorkingDays = 20;
            int Total_Employee_Wage;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            //if (empCheck == Is_Full_Time)
            //{
            //    Total_Employee_Wage = 12* Wage_per_Hour;
            //    Console.WriteLine(Total_Employee_Wage);
            //}
            //else if (empCheck == If_Part_Time)
            //{
            //    Total_Employee_Wage = 8 * Wage_per_Hour;
            //    Console.WriteLine(Total_Employee_Wage);
            //}
            //else
            //{
            //    Console.WriteLine("Employee is Absent");
            //}

            switch(empCheck)
            {
                case 1: Total_Employee_Wage = 12 * Wage_per_Hour * WorkingDays;
                      Console.WriteLine("Full Time Wage Is " + Total_Employee_Wage);
                    break;
                case 2: Total_Employee_Wage = 8 * Wage_per_Hour * WorkingDays;
                    Console.WriteLine("Half Time Wage Is " + Total_Employee_Wage); 
                    break;
                    default: Console.WriteLine("Employee is Absent");
                    break;
            }
        }


    }
}