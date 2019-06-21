using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        Backuper MyBackuper = new Backuper("Mybackuper");
        Backuper MyBackuper02 = new Backuper("Mybackuper02");
        private static System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();
        //aTimer.Tick += new EventHandler(TimerEventProcessor);

        public Form1()
        {
            InitializeComponent();
        }

        void Main()
        {
            


            // Start the timer
            
        }


        private void browseButtonForSource_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource.ShowDialog();
            textBox1.Text = folderBrowserDialogSource.SelectedPath;
        }

        private void browseButtonForSource02_Click(object sender, EventArgs e)
        {
            folderBrowserDialogSource2.ShowDialog();
            textBox3.Text = folderBrowserDialogSource2.SelectedPath;
        }

        private void browseButtonForDestination_Click(object sender, EventArgs e)
        {
            folderBrowserDialogDestination.ShowDialog();
            textBox2.Text = folderBrowserDialogDestination.SelectedPath;
        }

        private void browseButtonForDestination02_Click(object sender, EventArgs e)
        {
            folderBrowserDialogDestination2.ShowDialog();
            textBox4.Text = folderBrowserDialogDestination2.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxManualMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManualMode.Checked)
            {
                buttonBackup.Visible = true;
                buttonStop.Visible = true;
                labelInterval.Visible = false;
                numericUpDownInterval.Visible = false;
            }
            else
            {
                buttonBackup.Visible = false;
                buttonStop.Visible = false;
                labelInterval.Visible = true;
                numericUpDownInterval.Visible = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            aTimer.Enabled = false;
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            aTimer.Tick += new EventHandler(OnTimedEvent);
            aTimer.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MyBackuper.SourceDirectory = $@"{textBox1.Text}";
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
           
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (p, value) => { progressBar1.Value = value; label5.Text = $"{value.ToString()}%"; };
            Progress<string> progress2 = new Progress<string>();
            progress2.ProgressChanged += (p, value) => { label4.Text = $"Copying file {value}"; };
            Task.Run(() => MyBackuper.CopyFiles(progress,progress2));
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            aTimer.Interval = (int) numericUpDownInterval.Value;

            // Hook up the Elapsed event for the timer. 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MyBackuper.DestinationDirectory = $@"{textBox2.Text}";
           
        }
        private void OnTimedEvent(Object source, EventArgs e)
        {
            if(!checkBoxManualMode.Checked)
            {
                Progress<int> progress = new Progress<int>();
                progress.ProgressChanged += (p, value) => { progressBar1.Value = value; label5.Text = $"{value.ToString()}%"; };
                Progress<string> progress2 = new Progress<string>();
                progress2.ProgressChanged += (p, value) => { label4.Text = $"Copying file {value}"; };
                Task.Run(() => MyBackuper.CopyFiles(progress, progress2));
            }
        }

        private void checkBoxManual02_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManual02.Checked)
            {
                buttonBackup02.Visible = true;
                buttonStop02.Visible = true;
                label7.Visible = false;
                numericUpDown02.Visible = false;
            }
            else
            {
                buttonBackup02.Visible = false;
                buttonStop02.Visible = false;
                label7.Visible = true;
                numericUpDown02.Visible = true;
            }
        }
    }
}
