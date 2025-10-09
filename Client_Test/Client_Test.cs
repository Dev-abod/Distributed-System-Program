using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;


namespace Client_Test
{
    public partial class Client_Test : Form
    {
        public Client_Test()
        {
            InitializeComponent();
        }
        TcpClient Client;
        private void btn_Connect_Click(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Loopback;
            IPEndPoint ipe = new IPEndPoint(ip, 8090);
            UdpClient udpOne = new UdpClient();
            byte[] bToSend = Encoding.Unicode.GetBytes("Hello");
            udpOne.Send(bToSend, bToSend.Length, ipe);
        }
    }
}
