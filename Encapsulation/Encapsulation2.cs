using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    public class Encapsulation2
    {
        private String name;
        public String _name
        {
            get {

                return name;
            }
            set { 
            
                name = value;
            }
        }


        static void Main(String[] args)
        {
        
            Encapsulation2 obj = new Encapsulation2();
            obj._name = "Aniket";
            Console.WriteLine("The name of the Employee is: "+obj._name);
        }

    }
}
