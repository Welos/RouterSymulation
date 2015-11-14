using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    class Program
    {
        static void Main(string[] args)
        {

            Test t1 = new Test(100000,100000,15,10);
            Console.WriteLine();
            t1.HeapTest();
            Console.WriteLine();
            t1.UnsortedListTest();
            Console.WriteLine();

        }
    }
}
