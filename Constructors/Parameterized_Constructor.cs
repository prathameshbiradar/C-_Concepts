
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Parameterized_Constructor
    {
        // It is a Parameterized Constructor..

        String name;
        public Parameterized_Constructor(String name) { 
            this.name = name;   
        }
        static void Main(String[] args) { 
        
               Parameterized_Constructor obj =new Parameterized_Constructor("BridgeLabzz");
            Console.WriteLine("The name of the employee is: " + obj.name);
        
        }
    }
}
