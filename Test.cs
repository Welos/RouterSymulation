using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Router
{
    class Test
    {

        private  Object<int>[] o;
        private int numberOfInsertedElements;
        private int numberOfDeletedElements;

        public Test(int A, int B, int M, int N)
        {
            Stopwatch stopWatch = new Stopwatch();
            numberOfInsertedElements = A;
            numberOfDeletedElements = B;
            
            stopWatch.Start();
            Random r = new Random();
            o = new Object<int>[A + 1];
            o[A] = new Object<int>(r.Next(1, N), r.Next(1, 20), 2, 10);
            for (int i = 0; i < A; i++)
            {
                int a = r.Next(1, M);
                int b = r.Next(1, 4);
                int c = r.Next(1, 20);
                o[i] = new Object<int>(a, c, b, 10);
            }
            stopWatch.Stop();
            Console.WriteLine("Initialization time: {0}", stopWatch.Elapsed);
        }
        
        public void UnsortedListTest()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            UnsortedList<int> l1 = new UnsortedList<int>();
            for (int i = 0; i < numberOfInsertedElements; i++)
            {
                l1.Add(o[i]);
            }
            stopWatch.Stop();
            Console.WriteLine("Inserting into Unsorted List time: {0}", stopWatch.Elapsed);

            stopWatch.Start();
            for (int i = 0; i < numberOfDeletedElements; i++)
            {
                l1.ReturnMin();
            }

            l1.Add(o[numberOfInsertedElements]);
            stopWatch.Stop();
            Console.WriteLine("Deleting from Unsorted List and inserting 1 elemento time: {0}", stopWatch.Elapsed);
        }

        public void HeapTest()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            Heap<int> heap = new Heap<int>(numberOfInsertedElements + 1);
            
            for (int i = 0; i < numberOfInsertedElements; i++)
            {
                heap.Insert(o[i]);
            }
            stopWatch.Stop();
            Console.WriteLine("Inserting into Heap time: {0}", stopWatch.Elapsed);

            stopWatch.Start();
            heap.Check();
            Console.WriteLine("max index = {0}", heap.Max());
            for (int i = 0; i < numberOfDeletedElements; i++ )
                heap.DeleteMax();
            heap.Insert(o[numberOfInsertedElements]);
            stopWatch.Stop();
            Console.WriteLine("Deleting from Heap and inserting one element time: {0}", stopWatch.Elapsed);
        }
    }
}
