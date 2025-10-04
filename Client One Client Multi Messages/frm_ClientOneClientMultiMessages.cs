using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_One_Client_Multi_Messages
{
    public partial class frm_ClientOneClientMultiMessages : Form
    {
        public frm_ClientOneClientMultiMessages()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEnd = new IPEndPoint(ip, 8090);
            client = new TcpClient();
            client.Connect(ipEnd);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            byte[] bToSend = Encoding.Unicode.GetBytes(txt_Send.Text);
            client.GetStream().Write(bToSend, 0, bToSend.Length);
        }
        TcpClient client;
    }
}
