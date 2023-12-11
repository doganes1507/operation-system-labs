namespace MessageServices;

public class LocalSocketMessageService : ILocalMessageService
{
    public void SendMessage(int sendingPort, string message)
    {
        throw new NotImplementedException();
    }

    public string ReceiveMessage(int receivingPort)
    {
        throw new NotImplementedException();
    }
}