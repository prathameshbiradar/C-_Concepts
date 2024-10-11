/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstaction
{
    public abstract class Computer {

        public void name_of_computer() {

            Console.WriteLine("There are lot of types of computers");
        }
        public abstract void name() ;
        public abstract void storage();
    }
    public class Hp : Computer {

        public override void name() {
            Console.WriteLine("name of computer is HP");
        }
        public override void storage() {
            Console.WriteLine("Storage of computer is 1TB");
        }
    

    }
    public class Dell : Computer {


        public override void name() {
            Console.WriteLine("name of the laptop is Dell");
        }
        public override void storage()
        {
            Console.WriteLine("Storage of the laptop is 128GB");
        }
    }

   public class Abstract_class1
    {
        static void Main(string[] args)
        {
            Hp obj = new Hp();
            obj.name_of_computer();
            obj.name();
            obj.storage();

            Dell obj1 = new Dell();
            obj1.name_of_computer();
            obj1.name();
            obj1.storage();
        }
    }
}
*/