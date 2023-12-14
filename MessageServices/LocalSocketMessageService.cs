using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MessageServices;

public class LocalSocketMessageService : ILocalMessageService
{
    public void SendMessage(int sendingPort, string message)
    {
        var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Connect(IPAddress.Parse("127.0.0.1"), sendingPort);

        var data = Encoding.UTF8.GetBytes(message);
        socket.Send(data);
        
        socket.Close();
    }

    public string ReceiveMessage(int receivingPort)
    {
        var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Bind(new IPEndPoint(IPAddress.Any, receivingPort));
        socket.Listen(100);

        var listener = socket.Accept();
        var buffer = new byte[listener.SendBufferSize];
        var size = listener.Receive(buffer);
        
        socket.Close();
        
        return Encoding.UTF8.GetString(buffer, 0, size);
    }
}