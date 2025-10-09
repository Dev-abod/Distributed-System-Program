using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Inerface_Class_Library;

namespace Interface_Remoting_Client
{
    public partial class frm_InterfaceRemotingClient : Form
    {
        public frm_InterfaceRemotingClient()
        {
            InitializeComponent();
        }

        private void frm_InterfaceRemotingClient_Load(object sender, EventArgs e)
        {
            TcpChannel Channel = new TcpChannel(8090);
            ChannelServices.RegisterChannel(Channel);
            rInterface =
           (Operations)Activator.GetObject(typeof(Operations), "tcp://localhost:8090/RemotingURI");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rInterface.Add(Convert.ToInt32(txt_Num1.Text),
           Convert.ToInt32(txt_Num2.Text)).ToString());
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rInterface.Sub(Convert.ToInt32(txt_Num1.Text),
           Convert.ToInt32(txt_Num2.Text)).ToString());
        }
        Operations rInterface;

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rInterface.Mul(Convert.ToInt32(txt_Num1.Text),
          Convert.ToInt32(txt_Num2.Text)).ToString());
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rInterface.Div(Convert.ToInt32(txt_Num1.Text),
          Convert.ToInt32(txt_Num2.Text)).ToString());
        }
    }
    
}
