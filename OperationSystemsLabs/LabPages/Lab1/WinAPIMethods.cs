using System.Runtime.InteropServices;
using System.Text;

namespace OperationSystemsLabs.LabPages.Lab1;

public static class WinApiMethods
{
    [DllImport("kernel32.dll")]
    public static extern bool GetComputerName([Out] StringBuilder lpBuffer, ref int nSize);

    [DllImport("advapi32.dll")]
    public static extern bool GetUserName([Out] StringBuilder lpBuffer, ref int nSize);

    [DllImport("kernel32.dll")]
    public static extern int GetWindowsDirectory([Out] StringBuilder lpBuffer, ref int uSize);

    [DllImport("kernel32.dll")]
    public static extern int GetVersionEx(ref OsVersionInfoEx osVersionInfoEx);

    [DllImport("user32.dll")]
    public static extern int GetSystemMetrics(int nIndex);

    [DllImport("user32.dll")]
    public static extern bool SystemParametersInfo(int uiAction, int uiParam, out int pvParam, int fWinIni);

    [DllImport("kernel32.dll")]
    public static extern int GetSystemTime(out SystemTime lpSystemTime);

    [DllImport("kernel32.dll")]
    public static extern uint GetTickCount();

    [DllImport("shell32.dll")]
    public static extern IntPtr ShellExecute(IntPtr hwp, string lpOperation, string lpFile, string lpParameters,
        string lpDirectory, int nShowCmd);

    [DllImport("kernel32.dll")]
    public static extern void GlobalMemoryStatus(out MemoryStatus memoryStatus);

    [DllImport("kernel32.dll")]
    public static extern void GetSystemInfo(out SystemInfo lpSystemInfo);
}