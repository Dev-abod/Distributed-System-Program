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

namespace Proccess_Project
{
    public partial class frm_Proccess : Form
    {
        public frm_Proccess()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Process.Start(txt_ProccessName.Text);
        }

        private void btn_currentProccess_Click(object sender, EventArgs e)
        {
            Process proccess = Process.GetCurrentProcess();
            MessageBox.Show("Name : " + proccess.ProcessName + "Id : " + proccess.Id + " Main Title : " + proccess.MainWindowTitle);
        }

        private void btn_KillProccess_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void btn_AllProccesses_Click(object sender, EventArgs e)
        {
            Process[] proccesses = Process.GetProcesses();
            foreach (Process p in proccesses)
            {
                lst_Proccesses.Items.Add(p.ProcessName + "   " + p.Id);
            }
        }
        Process SelectedProcess;
        private void btn_KillSelected_Click(object sender, EventArgs e)
        {
            SelectedProcess =
  Process.GetProcessById(Convert.ToInt32(lst_Proccesses.SelectedItem.ToString().Substring(
  lst_Proccesses.SelectedItem.ToString().LastIndexOf(" "))));
            SelectedProcess.Kill();
        }

    
    }
}
