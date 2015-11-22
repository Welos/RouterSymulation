using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    public class Object<T> where T : new()  // szablonowa klasa objektu obslugiwanego przez kolejki priorytetowe / 
    {                                       // najwazniejsza zmienna Objektu jest key, sluzy ona do segregacji elementow/ zmienna statyczna pozwala na zlizcanie Objektow
        static int number;                  // pozostale zmienne nie sa wykorzystywane podczas testow, sluza jedynie pokazaniu jak moze wygladac pakiet w symulacji systemu
        public int key;
        public T ob
        {
            private set;
            get;
        }
        private double serviceTime;   
        private int importance;

        public Object()
        {
            this.key = 0;
            this.serviceTime = 0;
            this.importance = 0;
            this.ob = new T();
            number++;
        }
        public Object(int k, double sT, int i, T obj)
        {
            Random rand = new Random();
            this.key = k;
            this.serviceTime = sT;
            this.importance = i;
            this.ob = obj;
            number++;
        }
        ~Object()
        {
            number--;
        }
        public void setImportance(int i)
        {
            this.importance = i;
        }

    }
}
