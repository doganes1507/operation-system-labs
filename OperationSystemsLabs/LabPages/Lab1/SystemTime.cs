using System.Runtime.InteropServices;

namespace OperationSystemsLabs.LabPages.Lab1;

[StructLayout(LayoutKind.Sequential)]
public struct SystemTime
{
    public ushort wYear;
    public ushort wMonth;
    public ushort wDayOfWeek;
    public ushort wDay;
    public ushort wHour;
    public ushort wMinute;
    public ushort wSecond;
    public ushort wMilliseconds;
}