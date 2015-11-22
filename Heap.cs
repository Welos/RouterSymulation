
using System;

namespace Router
{
    public class Heap<T> : PriorityQueue<T> where T : new() // szerszy opis stogu znajduje sie w projekcie z symulacja / 
    {                                                       // jedyna roznica polega na uzyciu szablonow w tescie 
        private Object<T>[] data;                           // w symulacji szablony byly zbedne i jedynie utrudnialy zadanie
        public int HeapSize;


        public Heap(int num)
        {
            //dodaję zerowy element ponieważ zaczynamy wypełniać tablicę od indeksu 1
            data = new Object<T>[num];
            data[0] = null;
        }

        private void Swap(int index0, int index1)
        {
            Object<T> aux = data[index0];
            data[index0] = data[index1];
            data[index1] = aux;
        }

        override public void Insert(Object<T> ob)
        {
            HeapSize++;
            data[HeapSize] = ob;
            int Index = HeapSize;

            while (Index > 1)
            {
                if (ob.key > data[Index / 2].key)
                    Swap(Index, Index / 2);
                else break;
                Index = Index / 2;
            }
        }

        public void MoveDownHeap(int topIndex)
        {
            int index = topIndex;
            int n = data[topIndex].key;
            if (topIndex != 0)
            {
                while (index * 2 <= HeapSize)
                {
                    int indexGreater;
                    if ((index * 2 < HeapSize) && (data[index * 2 + 1].key > data[index * 2].key))
                        indexGreater = index * 2 + 1;
                    else
                        indexGreater = index * 2;
                    if (n < data[indexGreater].key)
                        Swap(index, indexGreater);
                    else break;
                    index = indexGreater;
                }
            }
        }

        override public Object<T> Delete()
        {
            data[1] = data[HeapSize];
            data[HeapSize] = null;
            HeapSize--;
            if (HeapSize != 0)
                MoveDownHeap(1);
            return data[1];
        }

        public void Construct(int index)
        {
            if (2 * index <= HeapSize / 2) Construct(2 * index);
            if (2 * index + 1 <= HeapSize / 2) Construct(2 * index + 1);
            MoveDownHeap(index);
        }

        public void Check()
        {
            for (int i = 1; i <= HeapSize / 2; i++)
            {
                if (data[i].key < data[2 * i].key) throw new Exception("Error in Heap");
                if (2 * i + 1 <= HeapSize)
                    if (data[i].key < data[2 * i + 1].key) throw new Exception("Error in Heap");
            }
        }

        public int Max()
        {
            return data[1].key;
        }

        public void CheckDeleteMax(Heap<T> heap)
        {
            int prev = int.MaxValue;
            for (int i = 1; i < heap.HeapSize; i++)
            {
                if (heap.Max() > prev) throw new Exception("Error in Heap");
                prev = heap.Max();
                heap.Delete();
            }
        }
        public void DrawTheHeap()
        {
            Console.WriteLine("                   {0}                  \n" +
                    "               {1}                      {2}      \n" +
                    "        {3}         {4}            {5}       {6}     \n" +
                    "       {7}   {9}        {9}  {10}         {11}  {12}         {13} {14}\n", data[1].key, data[2].key, data[3].key, data[4].key, data[5].key, data[6].key, data[7].key, data[8].key, data[9].key, data[10].key, data[11].key, data[12].key, data[13].key, data[14].key, data[15].key);
        }
    }
}
