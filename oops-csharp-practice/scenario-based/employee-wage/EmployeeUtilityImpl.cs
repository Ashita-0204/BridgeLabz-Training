using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.employee_wages
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        Random random = new Random();
        //private Employee employee;
        //UC0-- Add employee
        public Employee AddEmployee(Employee employee)
        {
            Console.WriteLine("Enter Employee ID");
            employee.EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee name ");
            employee.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Daily Wages");
            employee.DailyWages = int.Parse(Console.ReadLine());
            return employee;
        }
        //UC 1 Implementation 
        public void CheckAttendance()
        {
            int attendance = random.Next(0, 2);
            if (attendance == 0)
            {
                Console.WriteLine("The employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
        }
        //UC 2+ UC3 +UC4 Implementation
        public int CalculateDailyWage()
        {
            int empType = random.Next(0, 3);
            int hours = 0;

            switch (empType)
            {
                case 1:
                    hours = Employee.FULL_DAY_HOUR;
                    break;

                case 2:
                    hours = Employee.PART_TIME_HOUR;
                    break;

                default:
                    hours = 0;
                    break;
            }

            return hours * Employee.WAGE_PER_HOUR;
        }
    }
}