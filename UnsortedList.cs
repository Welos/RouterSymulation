using System;

namespace Router
{
        class UnsortedList<T> : PriorityQueue<T> where T: new()    //nieposortowana lista szablonowa
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
            public class Element                     //wezel listy
            {
                public Object<T> ob { get; set; }    //ob zaweiera elementy klasy T które chcemy przechowywać
                public Element next { get; set; }    //wskazanie na nastepny wezel
                public Element prev { get; set; }    //wskazanie na poprzedni wezel
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
            override public void Insert(Object<T> ob)
            {
                Element newElement = new Element(ob);
                if (first == null)                              //dodanie pierwszego elementu
                {
                    this.first = newElement;
                    this.last = this.first;
                    this.first.next = null;
                    this.first.prev = null;
                    this.last.next = null;
                    this.last.prev = null;
                }
                else                                             //dodanie elementu na koniec listy
                {

                    this.last.next = newElement;
                    newElement.prev = this.last;
                    this.last = newElement;
                    this.last.next = null;


                }
            }
            override public Object<T> Delete()              //wyjmowanie elementu o najmniejszej wartosci klucza
            {
                Element current = this.first;
                int min = current.ob.key;
                while (current.next != null)                 //każdorazowe przejscie po calej liscie
                {
                    if (current.ob.key < min)                //wyszukiwanie najmniejszej wartosci klucza
                    {
                        min = current.ob.key;
                    }
                    current = current.next;
                }
                if (current.ob.key < min)                    //porownanie kluczy dla ostatniego elementu(niespelniajacego warunku powyzszej petli)
                {
                    min = current.ob.key;
                }
                current = this.first;
                while (current.ob.key != min)                 //ponowne przeszukanie listy ale tylko do ustalonego elementu o najnizszej wartosci klucza
                {
                    current = current.next;
                }
                if (current == this.first)                    //zamiana polaczen gdy wyjmujemy pierwszy element
                {
                    this.first = this.first.next;
                    if (this.first != null)
                        this.first.prev = (null);
                }
                else if (current == this.last)                //zamiana polaczen gdy wyjmujemy ostatni element
                {
                    this.last = current.prev;
                    this.last.next = null;
                }
                else                                           //domyslna zamiana polaczen
                {
                    current.prev.next = current.next;
                    current.next.prev = current.prev;
                }
                return current.ob;
            }

            
        }
}
