using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Router
{
    class Program
    {
        static void TestOfUnsortedList(int A, int B, int M, int N)
        {
            UnsortedList<int> l1 = new UnsortedList<int>();
            l1.Test( A, B, M, N);

        }

        static void TestOfHeap(int A, int B, int M, int N)
        {
            Heap<int> heap = new Heap<int>(A + 1);
            heap.Test(A, B, M, N);

        }

        static void Main(string[] args)
        {
            int A = 10000; int B = 10001; int M = 20; int N = 15;
            Stopwatch stopWatchAll = new Stopwatch();

            stopWatchAll.Start();
            Console.WriteLine("List");
            TestOfUnsortedList(A, B, M, N);
            Console.WriteLine("Heap");
            TestOfHeap(A, B, M, N);
            stopWatchAll.Stop();
            Console.WriteLine("Total operation time: {0}", stopWatchAll.Elapsed);
        }
    }
}
