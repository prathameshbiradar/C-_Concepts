/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Concepts
{
    public class Call_by_value
    {
        static void Main(string[] args)
        {
            Call_by_value obj = new Call_by_value();
            int val = 10;
            Console.WriteLine("Value of integer before passing as argument: " + val);
            obj.show(val);
            Console.WriteLine("value of integer after passing as an argument: " + val);
        }
        public void show(int val)
        {
            val = val * val;
            Console.WriteLine("value of integer in function: " + val);
        }
    }
}
*/