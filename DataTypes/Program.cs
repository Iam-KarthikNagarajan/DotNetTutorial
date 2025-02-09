using System.Runtime.CompilerServices;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataType
            //int a = 1;
            //int b = 2;
            //int c = a + b;
            //Console.WriteLine("Integer " + c);

            //long a = 100000000000;
            //long b = 2;
            //long c = a + b;
            //Console.WriteLine("Long " + c);


            //float num1 = 1.23f;
            //float num2 = 2.23f;
            //float num3 = num1+ num2;
            //Console.WriteLine("Float " + num3);

            //double num1 = 1.233573;
            //double num2 = 2.23;
            //double num3 = num1 + num2;
            //Console.WriteLine("Double " + num3);
            #endregion

            ////======================================================================================

            #region Conversion
            ////Explicit Conversion
            //float a = 3.14f;
            //int b = (int)a;
            //Console.WriteLine(b);

            ////Implicit Conversion
            //int a = 10;
            //long b = a;
            //Console.WriteLine(b);
            //Console.WriteLine(b.GetType());
            //Console.WriteLine(a.GetType());

            ////======================================================================================

            ////Type Conversion
            //int a = 10;
            //Console.WriteLine(a);
            //Console.WriteLine(a.GetType());
            //string data = a.ToString();
            //Console.WriteLine(data);
            //Console.WriteLine(data.GetType());


            ////Parsing string to Integer
            //Console.WriteLine("Enter a two number:");
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //int c = Int32.Parse(a);
            //int d = Int32.Parse(b);
            //Console.WriteLine(c+d);
            #endregion

            ////======================================================================================

            #region String
            ////String Manipulation
            //string name = "Karthik";
            //int age = 27;
            //string location = "Chennai";

            //////Concatenation +
            //Console.WriteLine("Hi am "+ name + " my age is "+ age + " from "+ location);

            //////Formatting {0}{1}, a,b
            //Console.WriteLine("Hi am {0} my age is {1} from {2}", name, age, location);

            //////Interpolation $ {a}{b}
            //Console.WriteLine($"Hi am {name} \n my age is {age} from {location}");

            //////Verbatim @ [/n and raw space]
            //Console.WriteLine(@"Hi am {0} \n my age is {1} from {2}", name, age, location);
            //Console.WriteLine(@"D:\Learn\DotNet\DotNetTutorial");


            ////======================================================================================

            ////String Methods

            //string name = "Karthik";
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(name.ToUpper());

            //string a = string.Concat(" " + name +" ");
            //Console.WriteLine(a.Trim());

            //Console.WriteLine(name.Substring(3));


            //////String Operations
            //Console.WriteLine(name.IndexOf('r'));

            //bool data = string.IsNullOrWhiteSpace(a);
            //Console.WriteLine(data);
            #endregion

            ////======================================================================================
            #region Console Methods
            //int data = Console.Read();
            //Console.WriteLine(data);

            ////Hold and read
            //Console.ReadKey();
            #endregion

            #region methods
            Printer();
            Console.WriteLine(Cal());
            #endregion




        }

        public static void Printer()
        {
            Console.WriteLine("Hello world!");
        }

        public static int Cal()
        {
            int a = 1;
            int b = 2;
            return a+b;
        }




    }

}