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
using Remoting_Class_Library;

namespace Remoting_Server
{
    public partial class frm_RemotingServer : Form
    {
        public frm_RemotingServer()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            TcpChannel channel = new TcpChannel(8090);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemotingClass), "RemotingURI", WellKnownObjectMode.SingleCall);
        }
    }
}
