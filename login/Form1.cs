using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            String ip = ipaddressinput.Text;
            String port = portinput.Text;
            if(ip.Length<1 && port.Length<1)
            {
                connecting.Text = "type an ip address and port";
            }
            else if(port.Length<1)
            {
                connecting.Text = "type a port number";
            }
            else if(ip.Length<1)
            {
                connecting.Text = "type an ip address";
            }
            else
            {
                connecting.Text = "Conecting......";
            }
        }
        TcpListener listener = new TcpListener(System.Net.IPAddress.Any, 4500);
        private void startbutton_Click(object sender, EventArgs e)
        {            
            listener.Start();
            startlabel.Text = "Initiated";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            listener.Stop();
            startlabel.Text = "Terminated";
        }
    }
}
