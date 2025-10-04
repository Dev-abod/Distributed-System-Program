using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Multi_Client_Multi_Messages
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
            IPAddress ip = IPAddress.Parse("0.0.0.0");
            IPEndPoint ipEnd = new IPEndPoint(ip, 8090);
            TcpListener listener = new TcpListener(ipEnd);
            listener.Start();
            new Thread(() =>
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    byte[] bReceived = new byte[1024];
                    new Thread(() =>
                    {
                        while (true)
                        {
                            Array.Clear(bReceived, 0,
                           bReceived.Length);
                            client.GetStream().Read(bReceived, 0,
                           bReceived.Length);
                            string s =
                           Encoding.Unicode.GetString(bReceived);
                            lstMessage.Items.Add(s);
                        }
                    }).Start();
                }
            }).Start();
        }
    }
}
