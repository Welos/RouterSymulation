using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
namespace Router
{
    class Program
    {
        static TimeSpan TestOfUnsortedList(int A, int B, int M, int N) // funkcja tworzaca liste oraz inicjalizujaca funkcje testowa / 
        {                                                              // zwraca czas wykonania testu
            UnsortedList<int> l1 = new UnsortedList<int>();

            return l1.Test(A, B, M, N);

        }

        static TimeSpan TestOfHeap(int A, int B, int M, int N)  // funkcja tworzaca stog oraz inicjalizujaca funkcje testowa / 
        {                                                       // zwraca czas wykonania testu
            Heap<int> heap = new Heap<int>(A + 1);

            return heap.Test(A, B, M, N);

        }

        static void Main(string[] args)
        {

                int A = 10000; int B = 10001; int M = 20; int N = 15;
                Console.WriteLine("Wpisz wartosc A, ktora bedzie iloscia elementow w kolejce." + "\r\nA = ");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wpisz wartosc B, ktora bedzie iloscia usunietych najwiekszych elementow\r\nw kolejce." + "\r\nB = ");
                B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wpisz wartosc M, ktora bedzie domykac przedzial losowania liczb do kolejki." + "\r\nM = ");
                M = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wpisz wartosc N, ktora bedzie domykac przedzial z ktorego ma byc wylosowana\r\njedna liczba." + "\r\nN = ");
                N = Convert.ToInt32(Console.ReadLine());

                Stopwatch stopWatchAll = new Stopwatch();
                Stopwatch stopWatchEach = new Stopwatch();
                StreamWriter intoHeap = new StreamWriter("wynikiStogu1.txt");
                StreamWriter intoList = new StreamWriter("wynikiListy1.txt");

                stopWatchAll.Start();
                stopWatchEach.Start();
                Console.WriteLine("List");
                intoList.WriteLine("Times of List Test :" + TestOfUnsortedList(A, B, M, N));
                stopWatchEach.Stop();
                intoList.WriteLine("Total Time of list test : " + stopWatchEach.Elapsed);
                stopWatchEach.Start();
                Console.WriteLine("Heap");
                intoHeap.WriteLine("Times of Heap Test :" + TestOfHeap(A, B, M, N));
                stopWatchEach.Stop();
                intoHeap.WriteLine("Total time of Heap test : " + stopWatchEach.Elapsed);
                stopWatchAll.Stop();
                Console.WriteLine("Total operation time: {0}", stopWatchAll.Elapsed);
                
                
                intoHeap.Close();
                intoList.Close();



            }
        }
    }
}
