using System;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Inerface_Class_Library;

namespace Interface_Remoting_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            TcpChannel channel = new TcpChannel(8090);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemotingClassMath), "RemotingURI", WellKnownObjectMode.Singleton);
        }
        public class RemotingClassMath : MarshalByRefObject, Operations
        {
            public float Add(float Num1, float Num2)
            {
                return Num1 + Num2;
            }
            public float Sub(float Num1, float Num2)
            {
                return Num1 - Num2;
            }
            public float Mul(float Num1, float Num2)
            {
                return Num1 * Num2;
            }
            public float Div(float Num1, float Num2)
            {
                return Num1 / Num2;
            }
        }
    }
}
