using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server_Test
{
    public partial class Server_Test : Form
    {
        public Server_Test()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            UdpClient udpTwo = new UdpClient(8090);
            IPEndPoint ipe = null;
            byte[] bReceived = udpTwo.Receive(ref ipe);
            MessageBox.Show(Encoding.Unicode.GetString(bReceived));
        }
    }
}
