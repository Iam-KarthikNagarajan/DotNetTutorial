using System;
using System.Collections.Generic;
using System.Text;

namespace Two_interfaces_having_same_method_names
{
    public interface IEmployee
    {
        int EmployeeId { get; set; }
        string EmployeeName { get; set; }
        string Department { get; set; }

        void DisplayEmployeeDetails();
    }
}
