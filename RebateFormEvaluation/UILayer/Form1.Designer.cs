namespace RebateFormEvaluation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txttboxdisplaytot = new System.Windows.Forms.TextBox();
            this.lblbackspacenum = new System.Windows.Forms.Label();
            this.lbldescbackspace = new System.Windows.Forms.Label();
            this.lbltotaltime = new System.Windows.Forms.Label();
            this.txtboxdisplayintertimes = new System.Windows.Forms.TextBox();
            this.lblintermax = new System.Windows.Forms.Label();
            this.lblinteravg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblintermin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblintramax = new System.Windows.Forms.Label();
            this.lblinterrecorddesc = new System.Windows.Forms.Label();
            this.txtdisplayrecordtimes = new System.Windows.Forms.TextBox();
            this.lblavgrecordtime = new System.Windows.Forms.Label();
            this.lblavgtimedesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldescmintime = new System.Windows.Forms.Label();
            this.lblminrecordtime = new System.Windows.Forms.Label();
            this.lblmaxrecordtime = new System.Windows.Forms.Label();
            this.lbldescmaxtime = new System.Windows.Forms.Label();
            this.lbltitleperrecord = new System.Windows.Forms.Label();
            this.lblipfile = new System.Windows.Forms.Label();
            this.lblopfile = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnstartfileprcss = new System.Windows.Forms.Button();
            this.btnbrowseopfile = new System.Windows.Forms.Button();
            this.lbloutputfile = new System.Windows.Forms.Label();
            this.btnbrowseipfile = new System.Windows.Forms.Button();
            this.txtfileinputinstruction = new System.Windows.Forms.TextBox();
            this.lblinputfile = new System.Windows.Forms.Label();
            this.lbltotaltimedesc = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 1316);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 265;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txttboxdisplaytot
            // 
            this.txttboxdisplaytot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttboxdisplaytot.Enabled = false;
            this.txttboxdisplaytot.Location = new System.Drawing.Point(416, 596);
            this.txttboxdisplaytot.Multiline = true;
            this.txttboxdisplaytot.Name = "txttboxdisplaytot";
            this.txttboxdisplaytot.Size = new System.Drawing.Size(238, 51);
            this.txttboxdisplaytot.TabIndex = 384;
            this.txttboxdisplaytot.Text = "Total Time taken to enter all records, Total No of backspaces while entering 10 r" +
    "ecords";
            // 
            // lblbackspacenum
            // 
            this.lblbackspacenum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblbackspacenum.AutoSize = true;
            this.lblbackspacenum.Location = new System.Drawing.Point(381, 544);
            this.lblbackspacenum.Name = "lblbackspacenum";
            this.lblbackspacenum.Size = new System.Drawing.Size(23, 13);
            this.lblbackspacenum.TabIndex = 381;
            this.lblbackspacenum.Text = "lbl2";
            // 
            // lbldescbackspace
            // 
            this.lbldescbackspace.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbldescbackspace.AutoSize = true;
            this.lbldescbackspace.Location = new System.Drawing.Point(283, 544);
            this.lbldescbackspace.Name = "lbldescbackspace";
            this.lbldescbackspace.Size = new System.Drawing.Size(92, 13);
            this.lbldescbackspace.TabIndex = 380;
            this.lbldescbackspace.Text = "Backspace Count";
            // 
            // lbltotaltime
            // 
            this.lbltotaltime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotaltime.AutoSize = true;
            this.lbltotaltime.Location = new System.Drawing.Point(136, 544);
            this.lbltotaltime.Name = "lbltotaltime";
            this.lbltotaltime.Size = new System.Drawing.Size(35, 13);
            this.lbltotaltime.TabIndex = 379;
            this.lbltotaltime.Text = "label9";
            // 
            // txtboxdisplayintertimes
            // 
            this.txtboxdisplayintertimes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtboxdisplayintertimes.Enabled = false;
            this.txtboxdisplayintertimes.Location = new System.Drawing.Point(416, 434);
            this.txtboxdisplayintertimes.Multiline = true;
            this.txtboxdisplayintertimes.Name = "txtboxdisplayintertimes";
            this.txtboxdisplayintertimes.Size = new System.Drawing.Size(238, 59);
            this.txtboxdisplayintertimes.TabIndex = 378;
            this.txtboxdisplayintertimes.Text = "Max time: Max time gap between entry of two consecutive records, Min Time: Minimu" +
    "m consecutive time taken between two consecutive records,";
            // 
            // lblintermax
            // 
            this.lblintermax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblintermax.AutoSize = true;
            this.lblintermax.Location = new System.Drawing.Point(136, 372);
            this.lblintermax.Name = "lblintermax";
            this.lblintermax.Size = new System.Drawing.Size(35, 13);
            this.lblintermax.TabIndex = 375;
            this.lblintermax.Text = "label8";
            // 
            // lblinteravg
            // 
            this.lblinteravg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblinteravg.AutoSize = true;
            this.lblinteravg.Location = new System.Drawing.Point(597, 372);
            this.lblinteravg.Name = "lblinteravg";
            this.lblinteravg.Size = new System.Drawing.Size(23, 13);
            this.lblinteravg.TabIndex = 374;
            this.lblinteravg.Text = "lbl1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 373;
            this.label1.Text = "Average Time";
            // 
            // lblintermin
            // 
            this.lblintermin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblintermin.AutoSize = true;
            this.lblintermin.Location = new System.Drawing.Point(363, 372);
            this.lblintermin.Name = "lblintermin";
            this.lblintermin.Size = new System.Drawing.Size(35, 13);
            this.lblintermin.TabIndex = 372;
            this.lblintermin.Text = "label7";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 371;
            this.label4.Text = "Minimum Time";
            // 
            // lblintramax
            // 
            this.lblintramax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblintramax.AutoSize = true;
            this.lblintramax.Location = new System.Drawing.Point(58, 372);
            this.lblintramax.Name = "lblintramax";
            this.lblintramax.Size = new System.Drawing.Size(77, 13);
            this.lblintramax.TabIndex = 370;
            this.lblintramax.Text = "Maximum Time";
            // 
            // lblinterrecorddesc
            // 
            this.lblinterrecorddesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblinterrecorddesc.AutoSize = true;
            this.lblinterrecorddesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinterrecorddesc.Location = new System.Drawing.Point(58, 332);
            this.lblinterrecorddesc.Name = "lblinterrecorddesc";
            this.lblinterrecorddesc.Size = new System.Drawing.Size(97, 13);
            this.lblinterrecorddesc.TabIndex = 369;
            this.lblinterrecorddesc.Text = "Inter Record Times";
            this.lblinterrecorddesc.Click += new System.EventHandler(this.lblinterrecorddesc_Click);
            // 
            // txtdisplayrecordtimes
            // 
            this.txtdisplayrecordtimes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtdisplayrecordtimes.Enabled = false;
            this.txtdisplayrecordtimes.Location = new System.Drawing.Point(416, 244);
            this.txtdisplayrecordtimes.Multiline = true;
            this.txtdisplayrecordtimes.Name = "txtdisplayrecordtimes";
            this.txtdisplayrecordtimes.Size = new System.Drawing.Size(238, 55);
            this.txtdisplayrecordtimes.TabIndex = 367;
            this.txtdisplayrecordtimes.Text = "Max Time: Maximum Input time for a record, Min Time: Min Input time taken for a r" +
    "ecord, Average Time: Average of times of inputs of a single record.";
            // 
            // lblavgrecordtime
            // 
            this.lblavgrecordtime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblavgrecordtime.AutoSize = true;
            this.lblavgrecordtime.Location = new System.Drawing.Point(597, 188);
            this.lblavgrecordtime.Name = "lblavgrecordtime";
            this.lblavgrecordtime.Size = new System.Drawing.Size(17, 13);
            this.lblavgrecordtime.TabIndex = 365;
            this.lblavgrecordtime.Text = "lbl";
            // 
            // lblavgtimedesc
            // 
            this.lblavgtimedesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblavgtimedesc.AutoSize = true;
            this.lblavgtimedesc.Location = new System.Drawing.Point(518, 188);
            this.lblavgtimedesc.Name = "lblavgtimedesc";
            this.lblavgtimedesc.Size = new System.Drawing.Size(73, 13);
            this.lblavgtimedesc.TabIndex = 364;
            this.lblavgtimedesc.Text = "Average Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 363;
            // 
            // lbldescmintime
            // 
            this.lbldescmintime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbldescmintime.AutoSize = true;
            this.lbldescmintime.Location = new System.Drawing.Point(283, 188);
            this.lbldescmintime.Name = "lbldescmintime";
            this.lbldescmintime.Size = new System.Drawing.Size(74, 13);
            this.lbldescmintime.TabIndex = 362;
            this.lbldescmintime.Text = "Minimum Time";
            // 
            // lblminrecordtime
            // 
            this.lblminrecordtime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblminrecordtime.AutoSize = true;
            this.lblminrecordtime.Location = new System.Drawing.Point(363, 188);
            this.lblminrecordtime.Name = "lblminrecordtime";
            this.lblminrecordtime.Size = new System.Drawing.Size(35, 13);
            this.lblminrecordtime.TabIndex = 361;
            this.lblminrecordtime.Text = "label4";
            // 
            // lblmaxrecordtime
            // 
            this.lblmaxrecordtime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblmaxrecordtime.AutoSize = true;
            this.lblmaxrecordtime.Location = new System.Drawing.Point(136, 188);
            this.lblmaxrecordtime.Name = "lblmaxrecordtime";
            this.lblmaxrecordtime.Size = new System.Drawing.Size(35, 13);
            this.lblmaxrecordtime.TabIndex = 360;
            this.lblmaxrecordtime.Text = "label4";
            // 
            // lbldescmaxtime
            // 
            this.lbldescmaxtime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbldescmaxtime.AutoSize = true;
            this.lbldescmaxtime.Location = new System.Drawing.Point(58, 188);
            this.lbldescmaxtime.Name = "lbldescmaxtime";
            this.lbldescmaxtime.Size = new System.Drawing.Size(77, 13);
            this.lbldescmaxtime.TabIndex = 359;
            this.lbldescmaxtime.Text = "Maximum Time";
            // 
            // lbltitleperrecord
            // 
            this.lbltitleperrecord.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltitleperrecord.AutoSize = true;
            this.lbltitleperrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitleperrecord.Location = new System.Drawing.Point(58, 149);
            this.lbltitleperrecord.Name = "lbltitleperrecord";
            this.lbltitleperrecord.Size = new System.Drawing.Size(86, 13);
            this.lbltitleperrecord.TabIndex = 358;
            this.lbltitleperrecord.Text = "Times per record";
            // 
            // lblipfile
            // 
            this.lblipfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblipfile.AutoSize = true;
            this.lblipfile.Location = new System.Drawing.Point(220, 29);
            this.lblipfile.Name = "lblipfile";
            this.lblipfile.Size = new System.Drawing.Size(35, 13);
            this.lblipfile.TabIndex = 357;
            this.lblipfile.Text = "label4";
            // 
            // lblopfile
            // 
            this.lblopfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblopfile.AutoSize = true;
            this.lblopfile.Location = new System.Drawing.Point(599, 29);
            this.lblopfile.Name = "lblopfile";
            this.lblopfile.Size = new System.Drawing.Size(35, 13);
            this.lblopfile.TabIndex = 356;
            this.lblopfile.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 355;
            this.label2.UseMnemonic = false;
            // 
            // btnstartfileprcss
            // 
            this.btnstartfileprcss.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnstartfileprcss.Location = new System.Drawing.Point(223, 99);
            this.btnstartfileprcss.Name = "btnstartfileprcss";
            this.btnstartfileprcss.Size = new System.Drawing.Size(75, 22);
            this.btnstartfileprcss.TabIndex = 354;
            this.btnstartfileprcss.Text = "Start";
            this.btnstartfileprcss.UseVisualStyleBackColor = true;
            this.btnstartfileprcss.Click += new System.EventHandler(this.btnstartfileprcss_Click_1);
            // 
            // btnbrowseopfile
            // 
            this.btnbrowseopfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnbrowseopfile.Location = new System.Drawing.Point(518, 24);
            this.btnbrowseopfile.Name = "btnbrowseopfile";
            this.btnbrowseopfile.Size = new System.Drawing.Size(75, 22);
            this.btnbrowseopfile.TabIndex = 353;
            this.btnbrowseopfile.Text = "Browse";
            this.btnbrowseopfile.UseVisualStyleBackColor = true;
            this.btnbrowseopfile.Click += new System.EventHandler(this.btnbrowseopfile_Click_1);
            // 
            // lbloutputfile
            // 
            this.lbloutputfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbloutputfile.AutoSize = true;
            this.lbloutputfile.Location = new System.Drawing.Point(413, 29);
            this.lbloutputfile.Name = "lbloutputfile";
            this.lbloutputfile.Size = new System.Drawing.Size(83, 13);
            this.lbloutputfile.TabIndex = 352;
            this.lbloutputfile.Text = "Output File Path";
            // 
            // btnbrowseipfile
            // 
            this.btnbrowseipfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnbrowseipfile.Location = new System.Drawing.Point(139, 24);
            this.btnbrowseipfile.Name = "btnbrowseipfile";
            this.btnbrowseipfile.Size = new System.Drawing.Size(75, 22);
            this.btnbrowseipfile.TabIndex = 351;
            this.btnbrowseipfile.Text = "Browse ";
            this.btnbrowseipfile.UseVisualStyleBackColor = true;
            this.btnbrowseipfile.Click += new System.EventHandler(this.btnbrowseipfile_Click_1);
            // 
            // txtfileinputinstruction
            // 
            this.txtfileinputinstruction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtfileinputinstruction.Enabled = false;
            this.txtfileinputinstruction.Location = new System.Drawing.Point(416, 80);
            this.txtfileinputinstruction.Multiline = true;
            this.txtfileinputinstruction.Name = "txtfileinputinstruction";
            this.txtfileinputinstruction.Size = new System.Drawing.Size(238, 53);
            this.txtfileinputinstruction.TabIndex = 350;
            this.txtfileinputinstruction.Text = "Enter the output file path and input file path and start processing, reset to sta" +
    "rt over";
            // 
            // lblinputfile
            // 
            this.lblinputfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblinputfile.AutoSize = true;
            this.lblinputfile.Location = new System.Drawing.Point(58, 29);
            this.lblinputfile.Name = "lblinputfile";
            this.lblinputfile.Size = new System.Drawing.Size(75, 13);
            this.lblinputfile.TabIndex = 349;
            this.lblinputfile.Text = "Input File Path";
            // 
            // lbltotaltimedesc
            // 
            this.lbltotaltimedesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbltotaltimedesc.AutoSize = true;
            this.lbltotaltimedesc.Location = new System.Drawing.Point(58, 544);
            this.lbltotaltimedesc.Name = "lbltotaltimedesc";
            this.lbltotaltimedesc.Size = new System.Drawing.Size(57, 13);
            this.lbltotaltimedesc.TabIndex = 348;
            this.lbltotaltimedesc.Text = "Total Time";
            // 
            // btnreset
            // 
            this.btnreset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnreset.Location = new System.Drawing.Point(323, 98);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 385;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 674);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txttboxdisplaytot);
            this.Controls.Add(this.lblbackspacenum);
            this.Controls.Add(this.lbldescbackspace);
            this.Controls.Add(this.lbltotaltime);
            this.Controls.Add(this.txtboxdisplayintertimes);
            this.Controls.Add(this.lblintermax);
            this.Controls.Add(this.lblinteravg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblintermin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblintramax);
            this.Controls.Add(this.lblinterrecorddesc);
            this.Controls.Add(this.txtdisplayrecordtimes);
            this.Controls.Add(this.lblavgrecordtime);
            this.Controls.Add(this.lblavgtimedesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbldescmintime);
            this.Controls.Add(this.lblminrecordtime);
            this.Controls.Add(this.lblmaxrecordtime);
            this.Controls.Add(this.lbldescmaxtime);
            this.Controls.Add(this.lbltitleperrecord);
            this.Controls.Add(this.lblipfile);
            this.Controls.Add(this.lblopfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnstartfileprcss);
            this.Controls.Add(this.btnbrowseopfile);
            this.Controls.Add(this.lbloutputfile);
            this.Controls.Add(this.btnbrowseipfile);
            this.Controls.Add(this.txtfileinputinstruction);
            this.Controls.Add(this.lblinputfile);
            this.Controls.Add(this.lbltotaltimedesc);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.Text = "Rebate Form Evaluation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txttboxdisplaytot;
        private System.Windows.Forms.Label lblbackspacenum;
        private System.Windows.Forms.Label lbldescbackspace;
        private System.Windows.Forms.Label lbltotaltime;
        private System.Windows.Forms.TextBox txtboxdisplayintertimes;
        private System.Windows.Forms.Label lblintermax;
        private System.Windows.Forms.Label lblinteravg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblintermin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblintramax;
        private System.Windows.Forms.Label lblinterrecorddesc;
        private System.Windows.Forms.TextBox txtdisplayrecordtimes;
        private System.Windows.Forms.Label lblavgrecordtime;
        private System.Windows.Forms.Label lblavgtimedesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldescmintime;
        private System.Windows.Forms.Label lblminrecordtime;
        private System.Windows.Forms.Label lblmaxrecordtime;
        private System.Windows.Forms.Label lbldescmaxtime;
        private System.Windows.Forms.Label lbltitleperrecord;
        private System.Windows.Forms.Label lblipfile;
        private System.Windows.Forms.Label lblopfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnstartfileprcss;
        private System.Windows.Forms.Button btnbrowseopfile;
        private System.Windows.Forms.Label lbloutputfile;
        private System.Windows.Forms.Button btnbrowseipfile;
        private System.Windows.Forms.TextBox txtfileinputinstruction;
        private System.Windows.Forms.Label lblinputfile;
        private System.Windows.Forms.Label lbltotaltimedesc;
        private System.Windows.Forms.Button btnreset;
    }
}

