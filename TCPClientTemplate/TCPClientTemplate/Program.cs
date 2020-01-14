using System;
using System.IO;
using System.Net.Sockets;

namespace TCPClientTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient clientSocket = new TcpClient("127.0.0.1", 6789);
            Console.WriteLine("Client ready");

            Stream ns = clientSocket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;

            while (true)
            {
                string message = Console.ReadLine();

                if (message == "STOP" || message == "stop") break;
            }

            Console.WriteLine("No more from server. Press Enter");
            Console.ReadKey();

            ns.Close();
            clientSocket.Close();
        }
    }
}
