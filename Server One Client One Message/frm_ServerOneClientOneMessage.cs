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

namespace Server_One_Client_One_Message
{
    public partial class frm_ServerOneClientOneMessage : Form
    {
        public frm_ServerOneClientOneMessage()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("0.0.0.0");
            IPEndPoint ipEnd = new IPEndPoint(ip, 8090);
            TcpListener listener = new TcpListener(ipEnd);
            listener.Start();
            TcpClient client = listener.AcceptTcpClient();
            byte[] bReceived = new byte[1024];
            client.GetStream().Read(bReceived, 0, bReceived.Length);
            string s = Encoding.Unicode.GetString(bReceived);
            MessageBox.Show(s);
        }
    }
}
