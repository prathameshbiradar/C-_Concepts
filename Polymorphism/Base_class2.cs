using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cricketers {

        public virtual void bat() {

            Console.WriteLine("Cricketers use different types of bats");
        }
    }
    public class Rohit : Cricketers {

        public override void bat() {
            base.bat();
            Console.WriteLine("Rohit use CEAT company Bat");
        }
    }
    public class Base_class2
    {
        static void Main(string[] args) {

            Rohit ro = new Rohit();
            ro.bat();
        }
        
    }
}
