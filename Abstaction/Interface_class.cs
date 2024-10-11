using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction
{

     interface Rbi {

        void interest();
        void bank_contract();
    }
    interface Local_Rbi : Rbi {

        void established();
        void address();
    }
    public class Sbi : Rbi {

        public void interest() {

            Console.WriteLine("Interest rate is 7%");
        }
        public void bank_contract() { 
        
            Console.WriteLine("Contract is valid for 10 years");
        }
    }
    public class Axis : Local_Rbi
    {
        public void interest() {
            Console.WriteLine("Interest rate is 10%");
        }
        public void bank_contract() {
            Console.WriteLine("Contract is valid for 20 years");
        }
        public void established() {
            Console.WriteLine("Bank is Established in 2000");
        }
        public void address() { 
            Console.WriteLine("Bank address is Pune");
        }
    }



    public class Interface_class
    {
        static void Main(string[] args) {

            Sbi obj = new Sbi();
            obj.interest();
            obj.bank_contract();

            Axis axis = new Axis();
            axis.interest();
            axis.bank_contract();   
            axis.address();
            axis.established();

            Rbi obj1 = new Sbi();
            obj1.interest();

           

        }
    }
}
