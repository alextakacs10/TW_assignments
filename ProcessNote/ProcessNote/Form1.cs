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

        private string listView1_Click(object sender, EventArgs e)
        {
            int processID = Convert.ToInt32(listView1.SelectedItems[0].Text);
            Process selectedProcess = Process.GetProcessById(processID);
            string CPUusage;
            // set Memory usage
            MemoryBox.Text = (selectedProcess.WorkingSet64 / 1024000).ToString() + " MB";

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

        private void ProcessCPUThread(object sender, EventArgs e)
        {
            PerformanceCounter theCPUCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
            Timer t = new Timer();
            t.Tick += new EventHandler(ProcessCPUThread);
            string usage;

            try
            {
                Int32 processCPU = Convert.ToInt32(theCPUCounter.NextValue());
                usage = (processCPU / Environment.ProcessorCount).ToString();
            } catch (Exception)
            {
                 usage = "N/A";
            }
            }
    }
}
