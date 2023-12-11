namespace MessageServices;

public interface ILocalMessageService
{
    public void SendMessage(int sendingPort, string message);
    public string ReceiveMessage(int receivingPort);
}