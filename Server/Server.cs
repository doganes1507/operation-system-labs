using System.Diagnostics;
using System.Net.Sockets;
using MessageServices;
using WinApiServices;

namespace Server;

public class Server
{
    private ILocalMessageService MessageService { get; }
    private IWinApiService FunctionalityService { get; }
    private int PortNumber { get; set; }
    
    public Server(ILocalMessageService messageService, IWinApiService functionalityService, int portNumber)
    {
        MessageService = messageService;
        FunctionalityService = functionalityService;
        PortNumber = portNumber;
    }

    public void Run()
    {
        while (true)
        {
            string message;
            try
            {
                message = MessageService.ReceiveMessage(PortNumber).ToLower();
                Console.WriteLine("\nReceived a request!");
            }
            catch (SocketException)
            {
                Console.WriteLine($"Another server is already using the port number: {PortNumber}");
                while (true)
                {
                    Console.Write("Please enter the different port: ");
                    var input = Console.ReadLine();
                    
                    if (int.TryParse(input, out var port) && port is >= 1024 and <= 65535)
                    {
                        PortNumber = port;
                        break;
                    }
                }
                
                continue;
            }

            int senderPort;
            try
            {
                senderPort = ExtractSenderPort(message);
                Console.WriteLine($"Sender port number: {senderPort}");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to get the sender port number");
                continue;
            }

            string request;
            try
            {
                request = ExtractRequest(message);
                Console.WriteLine($"Request command: {request}");
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to parse request command");
                continue;
            }

            string response;
            try
            {
                response = FunctionalityService.ProcessRequest(request, Process.GetCurrentProcess());
            }
            catch (ArgumentException e)
            {
                response = e.Message;
            }
            
            MessageService.SendMessage(senderPort, response);
            Console.WriteLine($"Successfully send the response: {response}");
        }
    }

    private int ExtractSenderPort(string message)
    {
        var portSubstringStart = message.IndexOf("port:{") + 6;
        var portSubstringEnd = message.IndexOf('}', portSubstringStart);

        if (int.TryParse(message[portSubstringStart..portSubstringEnd], out var portNumber))
        {
            return portNumber;
        }

        throw new Exception();
    }

    private string ExtractRequest(string message)
    {
        var requestStart = message.IndexOf("request:{") + 9;
        var requestEnd = message.IndexOf('}', requestStart);

        return message[requestStart..requestEnd];
    }
}