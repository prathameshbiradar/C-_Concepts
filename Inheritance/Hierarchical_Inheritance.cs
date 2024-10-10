/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Rbl_bank {

        public void interest(int i) {
            Console.WriteLine("The interest of the bank is: "+i);
        }
    }
    public class State_bank : Rbl_bank {

        public void name_of_bank() {
            Console.WriteLine("Name of the bank is State Bank Of India");
        }

    }
    public class Axis_bank : Rbl_bank{
        public void name_of_bank() {
            Console.WriteLine("Name of the bank is bank Of India ");
        }

    }
    public class Hierarchical_Inheritance
    {
        static void Main(String[] args) {

            State_bank obj = new State_bank();
            obj.name_of_bank();
            obj.interest(7);
            Console.WriteLine();
            Axis_bank obj1 = new Axis_bank();
            obj1.name_of_bank();
            obj1.interest(10);

        }
        
            
    }
}
*/