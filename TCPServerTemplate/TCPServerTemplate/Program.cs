using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TCPServerTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 6789;
            TcpListener serverSocket = new TcpListener(ip, port);
            serverSocket.Start();
            Console.WriteLine("Server started");

            while (true)
            {
                TcpClient connectionSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("Server activated");

                ServiceTemplate service = new ServiceTemplate(connectionSocket);

                Thread myThread = new Thread(service.DoIt);

                myThread.Start();
            }
        }
    }
}
