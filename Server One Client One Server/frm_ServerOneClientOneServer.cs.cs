using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server_One_Client_One_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            UdpClient udpTwo = new UdpClient(8090);
            IPEndPoint ipe = null;
            byte[] bReceived = new byte[1024];
            bReceived = udpTwo.Receive(ref ipe);
            MessageBox.Show(Encoding.Unicode.GetString(bReceived));
        }
    }
}
