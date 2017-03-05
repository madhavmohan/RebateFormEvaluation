using RebateFormEvaluation.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateFormEvaluation.DataLayer
{
    //This class processes the input file and stores the values into the class member functions.
    class ProcessInptFile
    {
        Time t1 = new Time();
        //This function returns the list of record info's.
        public List<RecordInfo> ReturnListofRecords(String filename)
        {

            string line;
            int prevendtimemin = 0;
            int prevendtimesec = 0;
            int count = 0;
            int prevendtimehour = 0;
            List<RecordInfo> rcs = new List<RecordInfo>();
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@filename);
            while ((line = file.ReadLine()) != null)
            {

                string[] words = line.Split('\t');
                RecordInfo ri = new RecordInfo();

                String starttime = words[12];
                String endtime = words[13];
                

                string[] starttimes = starttime.Split(':');
                string[] endtimes = endtime.Split(':');
                ri.Endtimehour = Convert.ToInt32(endtimes[0]);
                ri.Starttimehour = Convert.ToInt32(starttimes[0]);
                ri.Endtimemin = Convert.ToInt32(endtimes[1]);
                ri.Endtimesec = Convert.ToInt32(endtimes[2]);
                ri.Starttimemin = Convert.ToInt32(starttimes[1]);
                ri.Starttimesec = Convert.ToInt32(starttimes[2]);
                int hour = ri.Endtimehour - ri.Starttimehour;
                int min = ri.Endtimemin - ri.Starttimemin;
                int sec = ri.Endtimesec - ri.Starttimesec;
                int[] rectimearr = t1.getMinutesandSeconds(t1.getTimeinSeconds(hour,min,sec));
                ri.Recordtimemin = rectimearr[0];
                ri.Recordtimesec = rectimearr[1];
                ri.Backspacecount = Convert.ToInt32(words[14]);
                //Set the value of inter record times here
                int[] interminsec = new int[3];
                int totstarttime = t1.getTimeinSeconds(ri.Starttimehour,ri.Starttimemin, ri.Starttimesec);
                int totendtime = t1.getTimeinSeconds(ri.Endtimehour, ri.Endtimemin, ri.Endtimesec);
                if (count == 0)
                {
                    ri.Intertimemin = 0 ;
                    ri.Intertimesec = 0;
                    prevendtimehour = ri.Endtimehour;
                    prevendtimemin = ri.Endtimemin;
                    prevendtimesec = ri.Endtimesec;
                }
                else
                {
                    int totalprevioustime = t1.getTimeinSeconds(prevendtimehour,prevendtimemin, prevendtimesec);
                    int totalstarttime = t1.getTimeinSeconds(ri.Starttimehour,ri.Starttimemin, ri.Starttimesec);
                    int totalintertime = totalstarttime - totalprevioustime;
                    int[] interminsecarr = t1.getMinutesandSeconds(totalintertime);
                    ri.Intertimemin = interminsecarr[0];
                    ri.Intertimesec = interminsecarr[1];
                    prevendtimehour = ri.Endtimehour;
                    prevendtimemin = ri.Endtimemin;
                    prevendtimesec = ri.Endtimesec;
                }
                rcs.Add(ri);
                count++;

            }

            file.Close();
            return rcs;

        }
    }
}
