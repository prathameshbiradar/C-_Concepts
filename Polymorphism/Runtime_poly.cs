
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {

        public virtual void eat() {
            Console.WriteLine("Animals can eat anything");
        }
    }
    class Dog : Animal {

        public override void eat() {
            Console.WriteLine("Dogs like cookies to eat");
        }
    
    }
    public class Runtime_poly
    {
        static void Main(String[] args) { 
            Dog obj = new Dog();    
            obj.eat();
            Animal obj1 = new Dog();
            obj1.eat(); 
        }
    }
}
