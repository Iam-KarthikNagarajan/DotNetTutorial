using System.Runtime.Intrinsics.X86;

namespace Two_interfaces_having_same_method_names
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Class1 c = new Class1();
            //c.Method();

            //IInterface1 i1 = new Class1(); 
            //i1.Method();

            //((IInterface2)new Class1()).Method();

            var c = new Class1();
            ((IInterface1)c).Method();
            ((IInterface2)c).Method();



            IEmployee employee = new Employee(101, "Karthik", "EEE", 50000);
            employee.DisplayEmployeeDetails();
            //employee.AnnualSalary();

            Employee employeeDetails = (Employee)employee;
            employeeDetails.AnnualSalary();

        }
    }
}