using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pulse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Start the server
            TcpHelper.StartServer(5678);
            TcpHelper.Listen(); // Start listening.
        }
    }
}