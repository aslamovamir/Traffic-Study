using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarter_Stoplight_Problem
{
    class Car
    {
        //private attributes for sequence number, arrival time, and exit time
        private int sequence_number, arrival_time, exit_time;

        //parametrized constructor: we wont know the exit time once the object is created
        public Car(int seq_num, int arr_time)
        {
            this.sequence_number = seq_num;
            this.arrival_time = arr_time;
        }

        //default constructor
        public Car()
        {
            this.sequence_number = 0;
            this.arrival_time = 0;
            this.exit_time = 0;
        }

        //setters
        public void SetSeqNum(int seq_num)
        {
            this.sequence_number = seq_num;
        }

        public void SetArrTime(int arr_time)
        {
            this.arrival_time = arr_time;
        }

        public void SetExitTime(int exit_time)
        {
            this.exit_time = exit_time;
        }

        //getters
        public int GetSeqNum()
        {
            return this.sequence_number;
        }

        public int GetArrTime()
        {
            return this.arrival_time;
        }

        public int GetExitTime()
        {
            return this.exit_time;
        }
    }
}
