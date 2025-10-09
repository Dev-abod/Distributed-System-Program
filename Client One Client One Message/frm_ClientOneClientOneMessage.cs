using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client_One_Client_One_Message
{
    public partial class frm_ClientOneClientOneMessage : Form
    {
        public frm_ClientOneClientOneMessage()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEnd = new IPEndPoint(ip, 8090);
            TcpClient client = new TcpClient();
            client.Connect(ipEnd);
            byte[] bToSend = Encoding.Unicode.GetBytes("hello");
            client.GetStream().Write(bToSend, 0, bToSend.Length);
        }
    }
}
