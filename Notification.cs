using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    class Notification
    {
        private int numberOfStream; 
        private double endTime;
        private double endOfWaiting;
        private double comingTime;
        private Notification()
        {
        }
        public Notification(int m_numberOfStream, double m_endTime, double m_endOfWaiting, double m_comingTime)
        {
            numberOfStream = m_numberOfStream;
            endTime = m_endTime;
            endOfWaiting = m_endOfWaiting;
            comingTime = m_comingTime;
        }
        public double GetEndTime() { return endTime; }
        public double GetEndOfWaiting() { return endOfWaiting; }
        public int GetNumberOfStream() { return numberOfStream; }
        public double GetComingTime() { return comingTime; }
    }

}
