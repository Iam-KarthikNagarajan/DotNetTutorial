using System;
using System.Collections.Generic;
using System.Text;

namespace Two_interfaces_having_same_method_names
{
    public class Employee : IEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public double EmployeeSalary { get; set; }

        public Employee(int employeeId, string employeeName, string department, double employeeSalary)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Department = department;
            EmployeeSalary = employeeSalary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Employee Name: {EmployeeName}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Employee Salary: {EmployeeSalary}");
        }

        public void AnnualSalary()
        {
            Console.WriteLine($"Employee AnnualSalary: {EmployeeSalary * 12}");
        }


    }
}
