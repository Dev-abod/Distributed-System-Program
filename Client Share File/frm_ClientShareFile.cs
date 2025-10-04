using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Share_File
{
    public partial class frm_ClientShareFile : Form
    {
        public frm_ClientShareFile()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_GetFile_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Loopback;
            IPEndPoint ipe = new IPEndPoint(ip, 8090);
            TcpClient client = new TcpClient();
            client.Connect(ipe);
            byte[] bFilePath =
           Encoding.Unicode.GetBytes(txt_GetFile.Text);
            client.GetStream().Write(bFilePath, 0, bFilePath.Length);
            FileStream fstream = new FileStream(Application.StartupPath + txt_GetFile.Text.Substring(txt_GetFile.Text.IndexOf("\\")),
           FileMode.Create);
            byte[] bFile = new byte[client.ReceiveBufferSize];
            new Thread(() =>
            {
                while (true)
                {
                    int count = client.GetStream().Read(bFile, 0,
                   bFile.Length);
                    fstream.Write(bFile, 0, count);
                    Array.Clear(bFile, 0, bFile.Length);
                    if (count == 0)
                    {
                        fstream.Close();
                        txt_GetFile.Text = "DONE";
                        break;
                    }
                }
            }).Start();
        }
    }
}
