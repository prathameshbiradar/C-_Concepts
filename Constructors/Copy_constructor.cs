/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Copy_constructor
    {
        // It is Copy Constructor 

        int x;
        public Copy_constructor(int x) { 
            this.x = x;
        }
        public Copy_constructor(Copy_constructor obj1 ) { 
            this.x = obj1.x;
        }
        public void display() {

            Console.WriteLine($"Value of x is : {x}");
        }

        static void Main(String[] args) {

            Copy_constructor obj = new Copy_constructor(10);
            obj.display();
            Copy_constructor obj1 = new Copy_constructor(obj);
            obj1.display();
        }

    }
}
*/