using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateFormEvaluation.BusinessLayer
{
    //This class stores the data from input file. It is used for processing by ProcessRecordInfo class
    class RecordInfo
    {
        int startimemin;
        int starttimehour;
        int endtimesec;
        int endtimemin;
        int endtimehour;
        int starttimesec;
        int recordno;
        int backspacecount;
        int intertimemin;
        int intertimesec;
        int recordtimemin;
        int recordtimesec;
        Time t1 = new Time();
        public int Backspacecount {
            get{
                return backspacecount;
            }
            set
            {
                backspacecount = value;
        
            }

        }

        public int Recordtimemin
        {
            get
            {
                return recordtimemin;
            }
            set
            {
                recordtimemin = value;
            
            }
        }
        public int Recordtimesec
        {
            get
            {
                return recordtimesec;

            }
            set
            {
                recordtimesec = value;
            }
        }
        public int Starttimehour
        {
            get
            {
                return starttimehour;
            }
            set
            {
                starttimehour = value;
            }
        }
        public int Endtimehour
        {
            get
            {
                return endtimehour;
            }
            set
            {
                endtimehour = value;
            }
        }
        public int Intertimemin
        {
            get
            {

                return intertimemin;
            }
            set
            {
                intertimemin = value;
            }
        }
        public int Intertimesec
        {
            get
            {

                
                return intertimesec;
            }
            set
            {
                intertimesec = value;
            }
        }

        public int Starttimemin
        {
            get
            {
                return startimemin;
            }
            set
            {
                startimemin = value;
            }
        }
        public int Endtimemin
        {
            get
            {
                return endtimemin;
            }
            set
            {
                endtimemin = value;
            }
        }
        public int Endtimesec
        {
            get
            {
                return endtimesec;
            }
            set
            {
                endtimesec = value;
            }
        }

        public int Starttimesec
        {
            get
            {
                return starttimesec;
            }
            set
            {
                starttimesec = value;
            }
        }

        public int Recordno
        {
            get
            {
                return recordno;
            }
            set
            {
                recordno = value;
            }
        }
    }
}
