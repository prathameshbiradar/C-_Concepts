
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Concepts
{
    public class Call_by_reference
    {
        static void Main(string[] args)
        {
            
            int val = 10;
            Console.WriteLine("Value of integer before passing as argument: " + val);
            show(ref val);
            Console.WriteLine("value of integer after passing as an argument: " + val);
        }
        public static void show(ref int val)
        {
            val = val * val;
            Console.WriteLine("value of integer in function: " + val);
        }


    }
}
