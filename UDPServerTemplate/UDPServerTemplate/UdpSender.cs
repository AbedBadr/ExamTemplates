using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UDPServerTemplate
{
    class UdpSender
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 9999;
            UdpClient udpSender = new UdpClient("127.0.0.1", port);

            IPEndPoint remoteIpEndPoint = new IPEndPoint(ip, port);

            int number = 0;

            while (true)
            {
                Console.WriteLine(number);

                Byte[] sendBytes = Encoding.ASCII.GetBytes("The number is: " + number);

                udpSender.Send(sendBytes, sendBytes.Length);

                number++;
                Thread.Sleep(100);
            }
        }
    }
}
