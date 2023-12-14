using System.Net.Sockets;
using MessageServices;

namespace Client;

public partial class ClientForm : Form
{
    private int PortNumber { get; }
    private ILocalMessageService MessageService { get; }

    public ClientForm(int portNumber)
    {
        InitializeComponent();

        PortNumber = portNumber;
        MessageService = new LocalSocketMessageService();

        Text = $"Client on port number: {portNumber}";
    }

    private bool IsPortNumberValid(string text)
    {
        return int.TryParse(text, out var portNumber) && portNumber is >= 1024 and <= 65535;
    }
    
    private void MakeRequest(string request, TextBox portNumberTextBox)
    {
        if (!IsPortNumberValid(portNumberTextBox.Text))
        {
            MessageBox.Show("Invalid server port number");
            return;
        }

        try
        {
            var serverPortNumber = int.Parse(portNumberTextBox.Text);
            var message = $"Port:{{{PortNumber}}} Request:{{{request}}}";
            MessageService.SendMessage(serverPortNumber, message);
            var response = MessageService.ReceiveMessage(PortNumber);

            MessageBox.Show($"Result: {response}");
        }
        catch (SocketException)
        {
            MessageBox.Show("Failed to connect to the server");
        }
    }
    
    private void GetWindowCoordinatesButton_Click(object sender, EventArgs e)
    {
        MakeRequest("WindowCoordinates", Server1PortTextBox);
    }

    private void GetPrimaryScreenResolutionButton_Click(object sender, EventArgs e)
    {
        MakeRequest("ScreenResolution", Server1PortTextBox);
    }

    private void GetNumberOfModulesButton_Click(object sender, EventArgs e)
    {
        MakeRequest("ModuleCount", Server2PortTextBox);
    }

    private void GetNumberOfThreadsButton_Click(object sender, EventArgs e)
    {
        MakeRequest("ThreadCount", Server2PortTextBox);
    }
}