using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace TCPServerTemplate
{
    class ServiceTemplate
    {
        private TcpClient _connectionSocket;

        public ServiceTemplate(TcpClient connection)
        {
            _connectionSocket = connection;
        }

        public void DoIt()
        {
            Stream ns = _connectionSocket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            while (true)
            {

            }
        }
    }
}
