using System;

namespace EmployeeDetails
{
    public class program
    {




        public static void Main()
        {
            int Is_Full_Time = 1;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
        }


    }
}