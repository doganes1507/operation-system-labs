namespace Client;

public partial class ClientInitializationForm : Form
{
    private HashSet<int> ExistingClientPorts { get; } = new();
    
    public ClientInitializationForm()
    {
        InitializeComponent();
    }

    private bool IsPortNumberValid(string text)
    {
        return int.TryParse(text, out var portNumber) && portNumber is >= 1024 and <= 65535;
    }

    private void CreateClientButton_Click(object sender, EventArgs e)
    {
        if (!IsPortNumberValid(PortNumberTextBox.Text))
        {
            MessageBox.Show("Invalid port number");
            return;
        }

        var newClientPort = int.Parse(PortNumberTextBox.Text);
        if (!ExistingClientPorts.Add(newClientPort))
        {
            MessageBox.Show("Another client is already using this port");
            return;
        }

        var newClient = new ClientForm(newClientPort);
        newClient.Show();
    }
}