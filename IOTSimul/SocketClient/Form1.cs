using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Net.Sockets;
using System.Net;
using System.IO;


namespace SocketClient
{
    public partial class Form1 : Form
    {

        public Socket clientSock_cliente;
        public IPEndPoint ipEnd_cliente;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*
                        textBox2.Text = @"356889014766303+161212190613+0020+007001+0012+00300+3+01+0001+0000+7+0000000001+01+0001+0000+7
            +0000000001+01+0001+0000+7+0000000001+01+0001+0000+7+0000000001+01+0000+0000+5+0000000706+01
            +0000+0000+5+0000000002+01+0000+0000+5+0000000002+01+0000+0000+5+0000000002+01+0001+0000+7
            +0000000579+01+0001+0000+7+0000000003+01+0001+0000+7+0000000003+01+0001+0000+7+0000000003
            +12/12/2016+19:07:46";
            */

            textBox2.Text = @"356889014766329+170602055728+0020+007001+0004+00180+3+01+1293+1104+0+0009537043+00+9999+9999+9+9999999999+00+9999+9999+9+9999999999+00+9999+9999+9+9999999999+00+9999+9999+9+9999999999+00+9999+9999+9+9999999999";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strEnderecoIP = textBox1.Text;   //"192.168.3.129";
            ipEnd_cliente = new IPEndPoint(IPAddress.Parse(strEnderecoIP), Convert.ToInt32(textBox3.Text));
            clientSock_cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            clientSock_cliente.Connect(ipEnd_cliente);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] clientData = new byte[1024];

            clientData = Encoding.UTF8.GetBytes(textBox2.Text);

            clientSock_cliente.Send(clientData, 0, clientData.Length, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientSock_cliente.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = label3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = label4.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = label8.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = label6.Text;

        }
    }
}
