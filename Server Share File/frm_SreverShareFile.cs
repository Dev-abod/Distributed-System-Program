using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Server_Share_File
{
    public partial class frm_SreverShareFile : Form
    {
        public frm_SreverShareFile()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = false;
            IPAddress ip = IPAddress.Any;
            IPEndPoint ipe = new IPEndPoint(ip, 8090);
            TcpListener listener = new TcpListener(ipe);
            listener.Start();
            new Thread(() =>
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    while (client.GetStream().DataAvailable == false) ;
                    byte[] bFilePath = new byte[client.Available];
                    client.GetStream().Read(bFilePath, 0, bFilePath.Length);
                    byte[] bFile = System.IO.File.ReadAllBytes(Encoding.Unicode.GetString(bFilePath));
                    client.GetStream().Write(bFile, 0, bFile.Length);
                    client.GetStream().Close();
                }
            }).Start();
        }
    }
}
