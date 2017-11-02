using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessNote
{
    public partial class Form1 : Form
    {
        Process[] processes = Process.GetProcesses();
        Dictionary<int, string> comments = new Dictionary<int, string>();
        Boolean commentSaved;
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void populateList()
        {
            foreach (Process process in processes)
            {
                String[] tempItem = new String[3];
                tempItem[0] = process.Id.ToString();
                tempItem[1] = process.ProcessName;
                listView1.Items.Add(new ListViewItem(tempItem));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateList();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            commentBox.Enabled = true;
            submitComment.Enabled = true;
            if (commentBox.Text == "")
            {
                feedBack.Text = "No comment added yet.";
            }
            int processID = Convert.ToInt32(listView1.SelectedItems[0].Text);
            Process selectedProcess = Process.GetProcessById(processID);

            ThreadButton.Text = "Show Threads (" + selectedProcess.Threads.Count.ToString() + ")";

            // set CUP usage
            float CPUu = (float)getCPUUsage();
            string CPUUsage = CPUu.ToString("0.00") + "%";

            CPUBox.Text = CPUUsage;
            
            // set Memory usage
            MemoryBox.Text = (selectedProcess.WorkingSet64 / 1024000).ToString() + " MB";

            // set Running time
            try
            {
                DateTime startTime = selectedProcess.StartTime;
                DateTime currentTime = DateTime.Now;
                TimeSpan runningTime = (currentTime - startTime);
                RunningTimeBox.Text = runningTime.TotalSeconds.ToString("0") + " s";
            } catch (Exception)
            {
                RunningTimeBox.Text = "N/A";
            }       

            // set Starting time
            try
            {
                StartedAtBox.Text = selectedProcess.StartTime.ToString();
            }
            catch (Exception)
            {
                StartedAtBox.Text = "N/A";
            }
        }

        private object getCPUUsage()
        {
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% processor Time", "_Total");
            dynamic firstValue = cpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            dynamic secondValue = cpuCounter.NextValue();

            return secondValue;
        }



        private void alwaysOnTop_CheckStateChanged(object sender, EventArgs e)
        {
            if (alwaysOnTop.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (commentSaved == true)
            {
                Close();
            } else
            {
                Form2 notSaved = new Form2();
                notSaved.Show();
            }
            
                
        }

        private void submitComment_Click(object sender, EventArgs e)
        {
            int processID = Convert.ToInt32(listView1.SelectedItems[0].Text);
            Process selectedProcess = Process.GetProcessById(processID);
            commentSaved = true;
            try
            {
                comments.Add(processID, commentBox.Text);
                feedBack.Text = "Comment saved.";
            }
            catch (ArgumentException)
            {
                feedBack.Text = "Comment overwritten.";
            }

                
            
        }

        private void commentBox_TextChanged(object sender, EventArgs e)
        {
            commentSaved = false;
            feedBack.Text = "Don't forget to submit your comment.";
        }
    }
}
