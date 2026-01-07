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
    }
}