using RebateFormEvaluation.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateFormEvaluation.DataLayer
{
    //This class writes to the text file.
    class WriteToTextFile
    {
        Time t1 = new Time();
        //The function writes times from the class  to the file.
        public Boolean WriteInfoToFile(string filename, ProcessRecordInfo pr)
        {
            

            try
            {

                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@filename))
                {
                    int[] intertimes = pr.ProcessInterTimes();

                    int[] recordtimes = pr.ProcessRecordTimes();
                    int totaltime = pr.returnTotalTime();
                    int backspacecount = pr.returnTotalBackspaceCount();
                    int[] avgrecarr = t1.getMinutesandSeconds(recordtimes[2]);
                    int[] maxrecarr = t1.getMinutesandSeconds(recordtimes[0]);
                    int[] minrecarr = t1.getMinutesandSeconds(recordtimes[1]);
                    int[] avgintertime = t1.getMinutesandSeconds(intertimes[2]);
                    int[] maxintertime = t1.getMinutesandSeconds(intertimes[0]);
                    int[] minintertime = t1.getMinutesandSeconds(intertimes[1]);
                    int[] tottimearr = t1.getMinutesandSeconds(totaltime);
                    String line1 = "No of records:" + "10";
                    String line2 = "Minimum Entry Time:" + minrecarr[0] + ":" + minrecarr[1];
                    String line3 = "Maximum Entry Time:" + maxrecarr[0] + ":" + maxrecarr[1];
                    String line4 = "Average Entry Time:" + avgrecarr[0] + ":" + avgrecarr[1];
                    String line5 = "Minimum inter-record time:" + minintertime[0] +":"+ minintertime[1];
                    String line6 = "Maximum inter-record time:" + maxintertime[0] + ":"+ maxintertime[1];
                    String line7 = "Average inter-record time:" + avgintertime[0] +":"+  avgintertime[1];
                    String line8 = "Total time:" + tottimearr[0]+":"+ tottimearr[1];
                    String line9 = "Backspace count:" + backspacecount;

                    file.WriteLine(line1);
                    file.WriteLine(line2);
                    file.WriteLine(line3);
                    file.WriteLine(line4);
                    file.WriteLine(line5);
                    file.WriteLine(line6);
                    file.WriteLine(line7);
                    file.WriteLine(line8);
                    file.WriteLine(line9);

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        
    }
}
