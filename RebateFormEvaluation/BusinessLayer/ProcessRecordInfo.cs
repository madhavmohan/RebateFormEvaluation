using RebateFormEvaluation.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateFormEvaluation.BusinessLayer
{
    //This class processes all the necessary operations to get the min, max times.
    class ProcessRecordInfo
    {
        public int maxrecordtime, minrecordtime, avgrecordtime;
        public  int maxintertime, minintertime, avgintertime;
        public int totaltimetaken=0;
        public int totalrecordtime=0;
        public int totalintertime = 0;
        Time t1 = new Time();
        List<RecordInfo> records = new List<RecordInfo>();
        int totalbackspacecount=0;

        //Find min, max, avg and total record times;
        public int[] ProcessRecordTimes()
        {
            int[] recordtimearr = new int[3];
            int count = 0;
            
            foreach (RecordInfo ri in records)
            {
                
                int totaltime = t1.getTimeinSeconds(0, ri.Recordtimemin, ri.Recordtimesec);
                if (count == 0)
                {
                    maxrecordtime = totaltime;
                    minrecordtime = totaltime;
                    avgrecordtime = totaltime;
                    totalrecordtime = totaltime;
                }
               else
                {
                    if (totaltime > maxrecordtime)
                    {
                        maxrecordtime = totaltime;
                    }
                    if (totaltime < minrecordtime)
                    {
                        minrecordtime = totaltime;
                    }
                    avgrecordtime += totaltime;
                    totalrecordtime += totaltime;
                    
                }
                count++;
            }
            avgrecordtime/= 10;
            recordtimearr[0] = maxrecordtime;
            recordtimearr[1] = minrecordtime;
            recordtimearr[2] = avgrecordtime;
            return recordtimearr;
        }
        //Find min, max, avg and total inter times
        public int[] ProcessInterTimes()
        {
            int count=0;

            int[] intertimearr = new int[3];
            foreach (RecordInfo ri in records)
            {
                
                int min = ri.Intertimemin;
                int sec = ri.Intertimesec;
                int totaltime = t1.getTimeinSeconds(0,min, sec);
                if (count == 0)
                {
                    maxintertime = totaltime;
                    minintertime = totaltime;
                    avgintertime = totaltime;
                    totalintertime = totaltime;
                    
                }
                else
                {
                    if (totaltime > maxintertime)
                    {
                        maxintertime = totaltime;
                    }
                    if (totaltime < minintertime)
                    {
                        minintertime = totaltime;
                    }
                    avgintertime += totaltime;
                    totalintertime += totaltime;
                    
                }
                count++;
            }
            avgintertime /= 10;
            intertimearr[0] = maxintertime;
            intertimearr[1] = minintertime;
            intertimearr[2] = avgintertime;
            return intertimearr;
        }

        //This returns the total time
        public int returnTotalTime()
        {
            
             return (totalintertime+totalrecordtime);
        }
        public void ProcessFileIntoRecords(string filename)
        {
            ProcessInptFile pi = new ProcessInptFile();
            foreach ( RecordInfo recinfo in   pi.ReturnListofRecords(filename)){
                records.Add(recinfo);
            }


        }
        //this returns the total backspace counts
        public int returnTotalBackspaceCount()
        {
            totalbackspacecount=0;
            foreach (RecordInfo ri in records) {
                totalbackspacecount += ri.Backspacecount;

            }
            return totalbackspacecount;
        }
        //This writes into another file
        public Boolean WriteIntotheFile(string filename)
        {
            WriteToTextFile wf = new WriteToTextFile();
            wf.WriteInfoToFile(filename, this);
            return true;
        }
    }
}
