using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server_One_Client_Multi_Messages
{
    public partial class frm_ServerOneClientMultiMessages : Form
    {
        public frm_ServerOneClientMultiMessages()
        {
            InitializeComponent();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("0.0.0.0");
            IPEndPoint ipEnd = new IPEndPoint(ip, 8090);
            TcpListener listener = new TcpListener(ipEnd);
            listener.Start();
            TcpClient client = listener.AcceptTcpClient();
            byte[] bReceived = new byte[1024];
            new Thread(() =>
            {
                while (true)
                {
                    Array.Clear(bReceived, 0, bReceived.Length);
                    client.GetStream().Read(bReceived, 0, bReceived.Length);
                    string s = Encoding.Unicode.GetString(bReceived);
                    lstMessage.Items.Add(s);
                }
            }).Start();
        }
    }
}
