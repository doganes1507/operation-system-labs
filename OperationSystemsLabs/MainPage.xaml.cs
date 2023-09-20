using OperationSystemsLabs.LabPages.Lab1;

namespace OperationSystemsLabs;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        Window.Width = 525;
        Window.Height = 700;
    }

    private void Lab1Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Lab1());
    }
}