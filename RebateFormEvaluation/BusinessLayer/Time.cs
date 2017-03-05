using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateFormEvaluation.BusinessLayer
{
    class Time
    {
        //This class is to process all time operations.
        int min;
        int sec;
        public int Minute
        {
            get
            {
                return min;
            }
            set
            {
                min = value;
            }

        }
        public int Second
        {
            get
            {
                return sec;
            }
            set
            {
                sec = value;
            }

        }
        //returns the time give in hour, min and sec in seconds
        public int getTimeinSeconds(int hour,  int min, int sec)
        {
            return ((hour*60*60) + (min * 60) + sec);
        }
        //gets the minutes and seconds from seconds
        public int[] getMinutesandSeconds(int time)
        {

            int[] minsecarr = new int[2];
            int min = time / 60;
            int sec = time - (min * 60);
            minsecarr[0] = min;
            minsecarr[1] = sec;
            return minsecarr;

        }
    }
}
