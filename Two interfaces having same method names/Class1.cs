using System;
using System.Collections.Generic;
using System.Text;

namespace Two_interfaces_having_same_method_names
{
    interface IInterface1
    {
        void Method();
    }
    interface IInterface2
    {
        void Method();
    }

    public class Class1 : IInterface1, IInterface2
    {
        void IInterface1.Method() 
        { 
            Console.WriteLine("Method from IInterface1");
        }
        void IInterface2.Method()
        {
            Console.WriteLine("Method from IInterface2");
        }
    }
}
