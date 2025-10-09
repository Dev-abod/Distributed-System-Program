using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UDP_Chat
{
    public partial class frm_Chat : Form
    {
        public frm_Chat()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            byte[] bToSend = Encoding.Unicode.GetBytes(txt_Send.Text);
            udpClient.Send(bToSend, bToSend.Length, new IPEndPoint(IPAddress.Parse("230.1.1.1"), 8080));
        }
        UdpClient udpClient;

        private void frm_Chat_Load(object sender, EventArgs e)
        {
            udpClient = new UdpClient(8080);
            udpClient.JoinMulticastGroup(IPAddress.Parse("230.1.1.1"));
            new Thread(() =>
            {
                while (true)
                {
                    IPEndPoint iPEndPoint = null;
                    byte[] bReceived = udpClient.Receive(ref iPEndPoint);
                    listBox1.Items.Add(iPEndPoint.Port + ":" + Encoding.Unicode.GetString(bReceived));
                }
            }).Start();
        }
    }
}
