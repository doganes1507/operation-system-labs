using System.Diagnostics;

namespace WinApiServices;

public class ModuleThreadService : IWinApiService
{
    public string ProcessRequest(string request, Process process)
    {
        return request.ToLower() switch
        {
            "modulecount" => GetNumberOfModules(process).ToString(),
            "threadcount" => GetNumberOfThreads(process).ToString(),
            _ => throw new ArgumentException("Failed to recognize the request")
        };
    }

    private int GetNumberOfModules(Process process)
    {
        return process.Modules.Cast<ProcessModule>().Count();
    }

    private int GetNumberOfThreads(Process process)
    {
        return process.Threads.Cast<ProcessThread>().Count();
    }
}