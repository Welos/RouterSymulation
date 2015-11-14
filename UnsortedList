using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
        class UnsortedList<T> where T: new()
        {
            public Element first;
            private Element last;
            public UnsortedList()
            {
                Element first = new Element();
                Element last = new Element();

                this.first = null;
                this.last = null;
            }
            public class Element
            {
                public Object<T> ob { get; set; }
                public Element next { get; set; }
                public Element prev { get; set; }
                public Element()
                {
                    next = null;
                    prev = null;
                    ob = null;
                }
                public Element(Object<T> obiekt)
                {
                    ob = obiekt;
                    next = null;
                    prev = null;
                }
            }
            public void Add(Object<T> ob)
            {
                Element newElement = new Element(ob);
                if (first == null)
                {
                    this.first = newElement;
                    this.last = this.first;
                    this.first.next = null;
                    this.first.prev = null;
                    this.last.next = null;
                    this.last.prev = null;
                }
                else
                {

                    this.last.next = newElement;
                    newElement.prev = this.last;
                    this.last = newElement;
                    this.last.next = null;


                }
            }
            public Object<T> ReturnMin()
            {
                Element current = this.first;
                int min = current.ob.key;
                while (current.next != null)
                {
                    if (current.ob.key < min)
                    {
                        min = current.ob.key;
                    }
                    current = current.next;
                }
                if (current.ob.key < min)
                {
                    min = current.ob.key;
                }
                current = this.first;
                while (current.ob.key != min)
                {
                    current = current.next;
                }
                if (current == this.first)
                {
                    this.first = this.first.next;
                    if (this.first != null)
                        this.first.prev = (null);
                }
                else if (current == this.last)
                {
                    this.last = current.prev;
                    this.last.next = null;
                }
                else
                {
                    current.prev.next = current.next;
                    current.next.prev = current.prev;
                }
                return current.ob;
            }
        }
}
