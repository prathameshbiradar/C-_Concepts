
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Concepts
{
    public class Out_Parameter
    {
        static void Main(String[] args) {


            int val=10;
            Console.WriteLine("Value befor passing as argument: " + val);
            show(out val);
            Console.WriteLine("Value after passing as argument: " + val);

        }
        static void show(out int val) {
            int square = 5;
            val =square;
            val *= val;

        }

    }
}

