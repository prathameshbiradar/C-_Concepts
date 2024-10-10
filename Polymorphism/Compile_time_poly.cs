/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Compile_time_poly
    {
        public void add() {
            Console.WriteLine("Adding Operation is Performed");
        }
        public void add(int a, int b) {
            Console.WriteLine("The addition of two numbers is: " + (a + b)) ;
        }
        public void add(String name) {
            Console.WriteLine("The name of the owner is: "+name);
        }

        static void Main(string[] args)
        {
            Compile_time_poly obj =new Compile_time_poly();
            obj.add();
            obj.add(1, 2);
            obj.add("Akash");
        }
    }
}
*/