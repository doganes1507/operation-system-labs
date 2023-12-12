using System.Diagnostics;
using static WinApiServices.WinApiMethods;

namespace WinApiServices;

public class WindowInfoService : IWinApiService
{
    public string ProcessRequest(string request, Process process)
    {
        switch (request.ToLower())
        {
            case "screenresolution":
                return GetPrimaryScreenResolution();
            
            case "windowcoordinates":
                try
                {
                    return GetWindowCoordinates(process);
                }
                catch (InvalidOperationException e)
                {
                    return "Server process has no window";
                }
                
            default:
                throw new ArgumentException("Failed to recognize the request");
        }
    }

    private string GetWindowCoordinates(Process process)
    {
        var mainWindowHandle = process.MainWindowHandle;

        var noWindowProcess = new InvalidOperationException("Failed to get the process window");

        if (mainWindowHandle == IntPtr.Zero)
            throw noWindowProcess;
        if (!GetWindowRect(mainWindowHandle, out var windowRect))
            throw noWindowProcess;

        return $"Top-left corner X:{windowRect.Left} Y:{windowRect.Top}\n" +
               $"Bottom-right corner X:{windowRect.Right} Y:{windowRect.Bottom}";
    }


    private string GetPrimaryScreenResolution()
    {
        var screenWidth = GetSystemMetrics(0);
        var screenHeight = GetSystemMetrics(1);

        return screenWidth + "x" + screenHeight;
    }
}