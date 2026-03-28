namespace OOPs { 
    class Program
    {
        public static void Main(string[] args)
        {
            #region Class & Object
            //Company company = new Company();

            //company.Id = 2;
            //company.name = "Youtube";
            //company.setter("Youtube");
            //company.Name = "Test";

            //company.DisplayCompanyDetails();

            //Console.WriteLine(company.getter());



            //Company company = new Company(1, "Google", "India");
            //company.DisplayCompanyDetails();

            //Company company1 = new Company(2, "Youtube");
            //company1.DisplayData();

            //Company company2 = new Company
            //{
            //    Id = 3,
            //    Name = "Facebook",
            //    Location = "India"
            //};

            //company2.DisplayCompanyDetails(); 
            #endregion




            Employee employee = new Employee(101, "Max", "TamilNadu", 30000, 1,"Google", "India");
            employee.DisplayCompanyDetails();
            employee.EmployeeDetails();
            employee.EmployeeCompanyDetails();
            employee.SalaryDetails();

            Boss fackBookBoss = new Boss(102, "Max", "NewYork", 40000, 2, "FaceBook", "USA");
            fackBookBoss.DisplayCompanyDetails();
            fackBookBoss.EmployeeDetails();
            fackBookBoss.EmployeeCompanyDetails();
            fackBookBoss.SalaryDetails();


            ExternalEmployee externalEmployee = new ExternalEmployee(103, "Max", 50000, 3, "FaceBook", "USA");
            externalEmployee.ExternalEmployeeDetails();
        }

    }
}
