using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace UDP_Client_Multi_Client_Multi_Server
{
    public partial class UDPMulti_Client_Multi_Server : Form
    {
        public UDPMulti_Client_Multi_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        UdpClient udpOne;
        private void btn_Send_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Loopback;
            IPEndPoint ipe = new IPEndPoint(ip, 8090);
            byte[] bToSend = Encoding.Unicode.GetBytes(txt_Send.Text);
            udpOne.Send(bToSend, bToSend.Length, ipe);
        }

        private void txt_Send_TextChanged(object sender, EventArgs e)
        {

        }

        private void UDPMulti_Client_Multi_Server_Load(object sender, EventArgs e)
        {
            udpOne = new UdpClient(8070);
            new System.Threading.Thread(() =>
            {
                while (true)
                {
                    IPEndPoint ipe = null;
                    byte[] bRceceived = udpOne.Receive(ref ipe);
                    listBox1.Items.Add(Encoding.Unicode.GetString(bRceceived));
                }
            }).Start();
        }

        private void UDPMulti_Client_Multi_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();

        }
    }
}
