using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    public class Object<T> where T: new()
    {
        static int number;
        public int key;
        public T ob
        {
            private set;
            get;
        }
        private double serviceTime;
        private int importance;

        public Object ()
        {
            this.key = 0;
            this.serviceTime = 0;
            this.importance = 0;
            this.ob = new T();
            number++;
        }
        public Object( int k, double sT, int i, T obj)
        {
            Random rand= new Random();
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
