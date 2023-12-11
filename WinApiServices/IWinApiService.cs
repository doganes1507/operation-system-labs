using System.Diagnostics;

namespace WinApiServices;

public interface IWinApiService
{
    public string ProcessRequest(string request, Process process);
}