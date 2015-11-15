using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    public enum KindOfEvent { Coming, GoingOutOfStream }; 
    public class Event
    {
        private KindOfEvent kind;
        private int StreamNumber;
        public int getStreamNumber() { return StreamNumber; }

        public Event(KindOfEvent kind, int m_StreamNumber)
        {
            StreamNumber = m_StreamNumber;
            this.kind = kind;
        }


        public static Event Coming(int n) { return new Event(KindOfEvent.Coming, n); }
        public static Event GoingOutOfStream(int n) { return new Event(KindOfEvent.GoingOutOfStream, n); }
        public KindOfEvent GerKind() { return kind; }
    }
}
