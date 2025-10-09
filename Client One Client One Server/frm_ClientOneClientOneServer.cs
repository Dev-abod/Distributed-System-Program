using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client_One_Client_One_Server
{
    public partial class frm_ClientOneClientOneServer : Form
    {
        public frm_ClientOneClientOneServer()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Loopback;
            IPEndPoint ipe = new IPEndPoint(ip, 8090);
            UdpClient udpOne = new UdpClient();
            byte[] bToSend = Encoding.Unicode.GetBytes(txt_Send.Text);
            udpOne.Send(bToSend, bToSend.Length, ipe);

        }
    }
}
