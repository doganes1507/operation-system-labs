using System.Diagnostics;
using System.Text;

namespace OperationSystemsLabs.LabPages.Lab2;

public partial class ProcessInfosPage
{
    public List<ProcessInfo> ProcessInfosList { get; } = new();

    public ProcessInfosPage()
    {
        InitializeComponent();
        GetProcessInfos();

        MyListView.ItemsSource = ProcessInfosList;
    }

    private void GetProcessInfos()
    {
        var processes = Process.GetProcesses();
        foreach (var process in processes)
        {
            var newProcessInfo = new ProcessInfo
            {
                ProcessNameAndId = $"Process Name: {process.ProcessName}, PID: {process.Id}"
            };

            var threads = process.Threads;
            var threadsString = new StringBuilder();
            foreach (ProcessThread thread in threads)
            {
                threadsString.Append($"Thread ID: {thread.Id}\n");
            }
            newProcessInfo.Threads = threadsString.ToString();
            
            ProcessInfosList.Add(newProcessInfo);

            // var modules = process.Modules;
            //     foreach (ProcessModule module in modules)
            //     {
            //         ProcessInfosList.Add($"  Module Name: {module.ModuleName}, Base Address: {module.BaseAddress}");
            //     }
            //
            //     ProcessInfosList.Add("");
        }
    }
}