using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class ExternalEmployee: Company
    {
        public int ExternalEmployeeID { get; set; }
        public string ExternalEmployeeName { get; set; }
        public double Salary { get; set; }

        public ExternalEmployee(int externalEmployeeId, string externalEmployeeName, double salary, int companyId, string companyName, string location) : base(companyId, companyName, location)
        {
            ExternalEmployeeID = externalEmployeeId;
            ExternalEmployeeName = externalEmployeeName;
            Salary = salary;
        }

        public void ExternalEmployeeDetails()
        {
            Console.WriteLine($"Employee Name: {ExternalEmployeeName}, Company Name: {CompanyName}, Location: {Location}");
        }
    }
}
