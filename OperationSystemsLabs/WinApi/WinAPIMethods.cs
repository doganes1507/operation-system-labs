using System.Runtime.InteropServices;
using System.Text;
using OperationSystemsLabs.WinApi.Structures;

namespace OperationSystemsLabs.WinApi;

public static class WinApiMethods
{
    // Methods for Lab 1
    
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
    
    
    // Methods for Lab 2
    
    
    [DllImport("kernel32.dll")]
    public static extern IntPtr LoadLibrary(string lpFileName);
    
    [DllImport("kernel32.dll")]
    public static extern int GetModuleFileName(IntPtr hModule, [Out] char[] lpFilename, int nSize);
    
    [DllImport("kernel32.dll")]
    public static extern uint GetCurrentProcessId();
    
    [DllImport("kernel32.dll")]
    public static extern IntPtr GetCurrentProcess();
    
    [DllImport("kernel32.dll")]
    public static extern bool DuplicateHandle(
        IntPtr hSourceProcessHandle,
        IntPtr hSourceHandle,
        IntPtr hTargetProcessHandle,
        out IntPtr lpTargetHandle,
        uint dwDesiredAccess,
        bool bInheritHandle,
        uint dwOptions
    );
    
    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(
        uint dwDesiredAccess,
        bool bInheritHandle,
        uint dwProcessId
    );
    
    [DllImport("kernel32.dll")]
    public static extern bool CloseHandle(IntPtr hObject);
    
    [DllImport("kernel32.dll")]
    public static extern IntPtr CreateToolHelp32Snapshot(uint dwFlags, uint th32ProcessId);
    
    [DllImport("kernel32.dll")]
    public static extern bool Process32First(IntPtr hSnapshot, ref ProcessEntry32 lppe);

    [DllImport("kernel32.dll")]
    public static extern bool Process32Next(IntPtr hSnapshot, ref ProcessEntry32 lppe);

    [DllImport("kernel32.dll")]
    public static extern bool Thread32First(IntPtr hSnapshot, ref ThreadEntry32 lpte);

    [DllImport("kernel32.dll")]
    public static extern bool Thread32Next(IntPtr hSnapshot, ref ThreadEntry32 lpte);

    [DllImport("kernel32.dll")]
    public static extern bool Module32First(IntPtr hSnapshot, ref ModuleEntry32 lpme);

    [DllImport("kernel32.dll")]
    public static extern bool Module32Next(IntPtr hSnapshot, ref ModuleEntry32 lpme);
}