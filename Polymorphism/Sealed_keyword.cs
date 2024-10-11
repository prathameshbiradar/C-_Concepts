/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // if we use sealed keyword before class then it can't be derived and if we use before method then it can't ovrride it.
    public sealed  class School {

        public School() {

            Console.WriteLine("Name of Every school is different");
        }
        public sealed virtual void  no_of_Students (){

            }
    }
    public class Nmc : School {

        public override void no_of_Students() {

            Console.WriteLine("There are 400 students in the school");
        }
    }
    public class Sealed_keyword
    {
    }
}
*/