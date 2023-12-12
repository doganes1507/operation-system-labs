using System.Net.Sockets;
using MessageServices;
using WinApiServices;

namespace Server;

public static class Program
{
    public static void Main()
    {
        var server = InitializeServer();
        server.Run();
    }

    private static Server InitializeServer()
    {
        Console.WriteLine("Welcome to the Server initialization wizard!");
        Console.WriteLine("Let's configure your new server\n");

        Console.WriteLine("The server can be of two types:");
        Console.WriteLine("\tType A: Provides information about the main monitor resolution or the coordinates of the server process window.");
        Console.WriteLine("\tType B: Provides the count of modules or threads in the server process.");

        IWinApiService functionalityService;
        while (true)
        {
            Console.Write("\nEnter the server type (A or B): ");
            var input = Console.ReadLine().ToLower();

            if (input == "a")
            {
                functionalityService = new WindowInfoService();
                break;
            }
            if (input == "b")
            {
                functionalityService = new ModuleThreadService();
                break;
            }

            Console.WriteLine("Invalid server type. Please enter 'A' or 'B'");
        }

        int port;
        while (true)
        {
            Console.Write("\nEnter the port number for the server: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out port) && port is >= 1024 and <= 65535)
            {
                break;
            }

            Console.WriteLine("Invalid port number. Please enter a valid port between 1024 and 65535.");
        }

        Console.WriteLine("\nServer initialized successfully!");
        Console.WriteLine("----------------------------------------------------------------");
        
        return new Server(new LocalSocketMessageService(), functionalityService, port);
    }
}