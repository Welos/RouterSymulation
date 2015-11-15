using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{

    class Stream
    {
        private string name;
        private int size; 
        private double waitingTime;
        private string durationDistribution;
        private string waitingDistribution;
        private int numberOfDurationDistribution;
        private int numberOfWaitingDistribution;

        public Stream(string m_name, int m_size, double m_WaitingTime, string m_durationDistribution,
            string m_waitingDistribution)
        {
            name = m_name;
            size = m_size;
            waitingTime = m_WaitingTime;
            durationDistribution = m_durationDistribution;
            waitingDistribution = m_waitingDistribution;
        }
        public string GetName() { return name; }
        public int GetNumberOfDurationDistribution() { return numberOfDurationDistribution; }
        public int GetNumberOfWaitingDistribution() { return numberOfWaitingDistribution; }
        public int GetSize() { return size; }
        public string GetNameOfDurationDistribution() { return durationDistribution; }
        public string GetNameOfWaitingDistribution() { return waitingDistribution; }
        public double GetWaitingTime() { return waitingTime; }

        public void SetNumberOfDurationDistribution(int m_numberOfDurationDistribution) { numberOfDurationDistribution = m_numberOfDurationDistribution; }
        public void SetNumberOdWaitingDistribution(int m_nemberOfWaitingDistribution) { numberOfWaitingDistribution = m_nemberOfWaitingDistribution; }
    }

}



