using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface Inter1
    {
        void f1();
    }
    interface Inter2
    {
        void f1();
    }
    class C3 : Inter1, Inter2
    {
         void Inter1.f1()
        {
            Console.WriteLine("this is overriding function of inter1 interface");
        }
         void Inter2.f1()
        {
            Console.WriteLine("this is overriding function of inter2 interface……..");
        }

    }

}
