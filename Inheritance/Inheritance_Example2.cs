using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class X {

        public X(int num)
        {
            Console.WriteLine($"The number passed in Constructor is: {num}");
        }
    }

     class Z : X  { 
        public  Z() : base(10)
            {
                Console.WriteLine("B class Constructor is called");
            }
    }

     class Inheritance_Example2
    {
        static void Main(String[] args) { 
        
            Z obj = new Z();    
        }
    }
}
