using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsAppClient
{
    public partial class Form1 : Form
    {
        private TcpClient _tcpClient = new TcpClient("localhost", 5555);
        private ASCIIEncoding ae = new ASCIIEncoding();
        
        public Form1()
        {
            InitializeComponent();
            region.Enabled = false;
            kind.Enabled = false;
            quant.Enabled = false;
            listBox1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radio_view.Checked)
            {
                NetworkStream ns = _tcpClient.GetStream();
                String command = "view";
                String res = command + "|";
                byte[] sent = ae.GetBytes(res);
                byte[] received = new byte[256];
                ns.Write(sent, 0, sent.Length);
                ns.Read(received, 0, received.Length);
                richTextBox1.Text = ae.GetString(received);
                String status = "=> Command sent: view data";
                listBox1.Items.Add(status);
            }
        }
    }
}