using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    class FIFOQueue 
    {

        private Notification[] queue;
        private int occupancy;

        public int GetOccupancy() { return occupancy; }
        public Notification[] GetQueue() { return queue; }

        public FIFOQueue(int size)
        {
            occupancy = 0;
            queue = new Notification[size];

        }

        public void SetNotification(Notification notif)
        {
            occupancy++;
            queue[occupancy - 1] = notif;
        }
        public Notification DeleteNotification(int i)
        {
            Notification tmp = queue[i];
            ChangeIndex(i);
            occupancy--;

            return tmp;
        }
        public Notification MoveToStream()
        {
            Notification tmp = queue[0];
            ChangeIndex(0);
            occupancy--;
            return tmp;
        }
        public double GetTimeOfNotification(int i)
        {
            return queue[i].GetEndTime();
        }

        public void ChangeIndex(int i)
        {
            for (int j = i; j < occupancy - 1; j++)
                queue[j] = queue[j + 1];
        }
    }
}
