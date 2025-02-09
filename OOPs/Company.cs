using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Company
    {
        //public int id = 1;
        //private string name = "Google";

        //public string getter()
        //{
        //    return name;
        //}
        //public void setter(string name)
        //{
        //    this.name = name;
        //}
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}


        public int Id { get; set; } = 1;
        public string Name { get; set; } = "Google";
        public string Location { get; set; } = "India";

        public Company(){

        }
        public Company(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Company(int id, string name, string location)
        {
            this.Id = id; 
            this.Name = name;
            this.Location = location;
        }


        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Location: {Location}");
        }

        public void DisplayData()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}");
        }

    }
}
