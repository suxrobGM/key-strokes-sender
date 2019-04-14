using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class ClientInstance
    {
        private TcpClient _client;
        private string _ipAddress;
        private int _port;

        public ClientInstance(string ipAddress, int port)
        {
            _ipAddress = ipAddress;
            _port = port;
        }

        public async Task SendMessageAsync(string message)
        {
            try
            {
                _client = new TcpClient(_ipAddress, _port);
                var data = Encoding.Unicode.GetBytes(message);

                await _client.GetStream().WriteAsync(data, 0, data.Length);
            }            
            finally
            {
                if (_client != null)
                {
                    _client.Close();
                }           
            }        
        }
    }
}
