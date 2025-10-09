using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Remoting_Class_Library;


namespace Remoting_Client
{
    public partial class frm_RemotingClient : Form
    {
        public frm_RemotingClient()
        {
            InitializeComponent();
        }

        private void btn_Square_Click(object sender, EventArgs e)
        {
            TcpChannel Channel = new TcpChannel();
            ChannelServices.RegisterChannel(Channel);
            RemotingClass rClass = (RemotingClass)Activator.GetObject(typeof(RemotingClass), "tcp://localhost:8090/RemotingURI");
            MessageBox.Show(rClass.Square(Convert.ToInt32(textBox1.Text)).ToString());
        }
    }
}
