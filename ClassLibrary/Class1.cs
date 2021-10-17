using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClassLibrary
{
    public class Class1
    {
        private static int _bufferSize = 52;

        private static void OnBeginAccept(IAsyncResult ar)
        {
            Socket listener = (Socket) ar.AsyncState;
            using (Socket client = listener.EndAccept(ar))
            {
                byte[] buffer = new byte[_bufferSize];
                client.Receive(buffer);
                buffer = Encoding.UTF8.GetBytes($"Hello, {Encoding.UTF8.GetString(buffer)}");
                client.Send(buffer);
            }
        }

        public static void Main()
        {
            EndPoint endPoint = new IPEndPoint(IPAddress.Loopback, 8320);
            using (Socket listener = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp))
            using (Socket client = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp))
            {
                listener.Bind(endPoint);
                listener.Listen(1);
                listener.BeginAccept(new AsyncCallback(OnBeginAccept), listener);
                client.Connect(endPoint);
                
                Console.Write("Input a message: ");
                string request = Console.ReadLine();
                int count = client.Send(Encoding.UTF8.GetBytes(request ?? throw new InvalidOperationException()));
                byte[] buffer = new byte[_bufferSize];
                client.Receive(buffer);
                string response = Encoding.UTF8.GetString(buffer);
                int index = response.IndexOf('\0');
                Console.WriteLine($"Server's response: {response.Remove(index)}");
            }
        }
    }
}