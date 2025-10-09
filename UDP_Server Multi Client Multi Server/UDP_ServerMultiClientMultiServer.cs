using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UDP_Server_Multi_Client_Multi_Server
{
    public partial class UDP_ServerMultiClientMultiServer : Form
    {
        public UDP_ServerMultiClientMultiServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        UdpClient udpTwo;

        private void UDP_ServerMultiClientMultiServer_Load(object sender, EventArgs e)
        {
            udpTwo = new UdpClient(8090);
            new System.Threading.Thread(() =>
            {
                while (true)
                {
                    IPEndPoint ipe = null;
                    byte[] bReceived = udpTwo.Receive(ref ipe);
                    listBox1.Items.Add(Encoding.Unicode.GetString(bReceived));
                }
            }).Start();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            IPEndPoint ipe = new IPEndPoint(IPAddress.Loopback, 8070);
            byte[] bToSend = Encoding.Unicode.GetBytes(txt_Send.Text);
            udpTwo.Send(bToSend, bToSend.Length, ipe);
        }

        private void UDP_ServerMultiClientMultiServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
