using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UDPServerTemplate
{
    class UdpSenderBroadcast
    {
        static void Main1(string[] args)
        {
            int number = 0;

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 9999;
            UdpClient udpSender = new UdpClient();

            udpSender.EnableBroadcast = true;

            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Broadcast, port);

            while (true)
            {
                Console.WriteLine(number);

                Byte[] sendBytes = Encoding.ASCII.GetBytes("The number is: " + number);

                udpSender.Send(sendBytes, sendBytes.Length, remoteIpEndPoint);

                number++;
                Thread.Sleep(100);
            }
        }
    }
}
