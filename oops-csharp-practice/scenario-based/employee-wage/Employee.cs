using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.employee_wages
{
    internal class Employee
    {
        //initializing variables
        private int empId;
        private string empName;
        private int dailyWages;
        public const int WAGE_PER_HOUR = 20;
        public const int FULL_DAY_HOUR = 8;
        public const int PART_TIME_HOUR = 4;
        //getters and setters
        public int EmpId { get => empId; set => empId = value; }
        public string EmpName { get => empName; set => empName = value; }
        public int DailyWages { get => dailyWages; set => dailyWages = value; }
        //overriding tostring method
        public string ToString()
        {
            return "Employee name is " + EmpName + "with emp id as " + EmpId + " has daily wages of " + DailyWages;
        }

    }
}
