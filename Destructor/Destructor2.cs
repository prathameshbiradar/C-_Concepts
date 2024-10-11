using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{

    public class A {
         ~A() {
            Console.WriteLine("Class A object is destroyed");
        }
    }
    public class B : A {
        ~B() {
            Console.WriteLine("Class B object is Destroyed");
        }
    }
    public class C : B 
    {
        ~C() {
            Console.WriteLine("Class C object is Destroyed");
        }
    }
   
    public class Destructor2
    {
        static void Main(String[] args) {

            C obj = new C();
            obj = null;
            GC.Collect();

        }


    }
}
