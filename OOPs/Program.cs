namespace OOPs { 
    class Program
    {
        public static void Main(string[] args)
        {
            //Company company = new Company();

            //company.Id = 2;
            //company.name = "Youtube";
            //company.setter("Youtube");
            //company.Name = "Test";

            //company.DisplayCompanyDetails();

            //Console.WriteLine(company.getter());



            Company company = new Company(1, "Google", "India");
            company.DisplayCompanyDetails();

            Company company1 = new Company(2, "Google");
            company1.DisplayData();

            Company company2 = new Company
            {
                Id = 3,
                Name = "Facebook",
                Location = "India"
            };

            company2.DisplayCompanyDetails();


        }

    }
}
