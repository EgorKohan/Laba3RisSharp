using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fileName = "file1.txt";
            int fileCount = 0;
            TcpListener listener;
            Socket socket;
            NetworkStream ns;
            listener = new TcpListener(IPAddress.Any, 5555);
            listener.Start();
            socket = listener.AcceptSocket();
            if (socket.Connected)
            {
                ns = new NetworkStream(socket);
                ThreadClass threadClass = new ThreadClass();
                Thread thread = threadClass.Start(ns, fileName, fileCount, this);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    internal class ThreadClass
    {
        private NetworkStream _ns;
        private string _fileName;
        private Form1 _form;
        private int _fileCount;
        private ASCIIEncoding ae;

        public Thread Start(NetworkStream ns, string fileName, int fileCount, Form1 form1)
        {
            _ns = ns;
            ae = new ASCIIEncoding();
            _fileName = fileName;
            _fileCount = fileCount;
            _form = form1;
            Thread thread = new Thread(ThreadOperations);
            thread.Start();
            return thread;
        }

        private void ThreadOperations()
        {
            byte[] received = new byte[256];
            _ns.Read(received, 0, received.Length);
            String s1 = ae.GetString(received);
            int i = s1.IndexOf("|", 0);
            String cmd = s1.Substring(0, i);
            if (cmd.CompareTo("view") == 0)
            {
                byte[] sent = new byte[256];
                FileStream fstr = new FileStream(_fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fstr);
                sent = ae.GetBytes(sr.ReadToEnd());
                sr.Close();
                fstr.Close();
                _ns.Write(sent, 0, sent.Length);
                
            }

        }
    }
}