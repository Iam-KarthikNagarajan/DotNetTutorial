using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Employee : Company, IEmployee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }

        public Employee(int employeeId, string employeeName, string address, double salary, int companyId, string companyName, string location) : base(companyId, companyName, location)
        {
            EmployeeID = employeeId;
            EmployeeName = employeeName;
            Address = address;
            Salary = salary;
        }

        public void EmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}, Employee Name: {EmployeeName}, Address: {Address}, Salary: {Salary}");
        }

        public void EmployeeCompanyDetails()
        {
            Console.WriteLine($"Employee Name: {EmployeeName}, Company Name: {CompanyName}, Location: {Location}");
        }

        public void salaryDetails()
        {
            Console.WriteLine($"Employee Name: {EmployeeName}, Salary: {Salary}");
        }
    }
}
