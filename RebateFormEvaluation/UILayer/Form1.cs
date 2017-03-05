using RebateFormEvaluation.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This class has the gui and the calls the business layer  for getting the fields to be displayed in the gui.
namespace RebateFormEvaluation
{
    public partial class Form1 : Form
    {
        ProcessRecordInfo pr;
        string outputfilename;
        string inputfilename;
        Time t1 = new Time();
        public void HideAllLabels()
        {
            lblavgrecordtime.Hide();
            lblbackspacenum.Hide();
            lblipfile.Hide();
            lblopfile.Hide();
            lblmaxrecordtime.Hide();
            lblminrecordtime.Hide();
            lblavgrecordtime.Hide();
            lbltotaltime.Hide();
            lblbackspacenum.Hide();
            lblinteravg.Hide();
            lblintermax.Hide();
            lblintermin.Hide();
            lblopfile.Hide();
            lblipfile.Hide();
            

        }
        public void ShowAllLabels()
        {
            lblavgrecordtime.Show();
            lblbackspacenum.Show();
            lblipfile.Show();
            lblopfile.Show();
            lblmaxrecordtime.Show();
            lblminrecordtime.Show();
            lblavgrecordtime.Show();
            lbltotaltime.Show();
            lblbackspacenum.Show();
            lblinteravg.Show();
            lblintermax.Show();
            lblintermin.Show();
            lblopfile.Show();
            lblipfile.Show();

        }
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            HideAllLabels();
        }


        private void txtfileinputinstruction_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblinputfile_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblmintime_Click(object sender, EventArgs e)
        {

        }

        private void lbldescbackspace_Click(object sender, EventArgs e)
        {

        }



  

   
          
        private void lblopfile_Click(object sender, EventArgs e)
        {

        }

        private void lblbackspacedesc_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblavgtimedesc_Click(object sender, EventArgs e)
        {

        }
        //Output File dialog function which accepts  the file from the user.

        private void btnbrowseopfile_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                try
                {
                    outputfilename = openFileDialog2.SafeFileName;
                    lblopfile.Text = outputfilename;
                    lblopfile.Show();


                }
                catch (Exception ex)
                {


                }


            }
        }

        private void lblinterrecorddesc_Click(object sender, EventArgs e)
        {

        }

        private void btndisplayrecordtimes_Click(object sender, EventArgs e)
        {
           
            
           
        }
        //This is used to start the process
        private void btnstartfileprcss_Click_1(object sender, EventArgs e)
        {
            pr = new ProcessRecordInfo();
            if ((inputfilename!= null) && (outputfilename != null))
            {
                pr.ProcessFileIntoRecords(openFileDialog1.FileName);
                pr.WriteIntotheFile(openFileDialog2.FileName);
                int[] intertimes=pr.ProcessInterTimes();
                
                int[] recordtimes=pr.ProcessRecordTimes();
                int totaltime = pr.returnTotalTime();

                int backspacecount = pr.returnTotalBackspaceCount();
                
                int[] avgrecarr = t1.getMinutesandSeconds(recordtimes[2]);
                int[] maxrecarr = t1.getMinutesandSeconds(recordtimes[0]);
                int[] minrecarr = t1.getMinutesandSeconds(recordtimes[1]);
                int[] avgintertime = t1.getMinutesandSeconds(intertimes[2]);
                int[] maxintertime = t1.getMinutesandSeconds(intertimes[0]);
                int[] minintertime = t1.getMinutesandSeconds(intertimes[1]);
                int[] tottime = t1.getMinutesandSeconds(totaltime);
               // txtboxdisplayintertimes.BackColor = Color.Green;
                //txtdisplayrecordtimes.BackColor = Color.Green;
                lblavgrecordtime.Text = avgrecarr[0] + ":" + avgrecarr[1];
                lblmaxrecordtime.Text = maxrecarr[0] + ":" + maxrecarr[1];
                lblminrecordtime.Text = minrecarr[0] + ":" + minrecarr[1];
                lblinteravg.Text = avgintertime[0] + ":" + avgintertime[1];
                lblintermax.Text = maxintertime[0] + ":" + maxintertime[1];
                lblintermin.Text = minintertime[0] + ":" + minintertime[1];
                lblbackspacenum.Text = Convert.ToString(backspacecount);
                lbltotaltime.Text = tottime[0] + ":" + tottime[1];
                ShowAllLabels();

            }
            else
            {
                txtfileinputinstruction.Text = "Please enter file names before starting processing";
                //txtfileinputinstruction.BackColor = Color.Red;
            }

        }
        //input file accept function
        private void btnbrowseipfile_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                try
                {
                    inputfilename = openFileDialog1.SafeFileName;
                    lblipfile.Text = inputfilename;
                    lblipfile.Show();
                    lblipfile.Refresh();

                }
                catch (Exception ex)
                {


                }


            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            HideAllLabels();
        }
    }
}
