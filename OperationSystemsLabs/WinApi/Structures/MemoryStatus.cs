using System.Runtime.InteropServices;

namespace OperationSystemsLabs.WinApi.Structures;

[StructLayout(LayoutKind.Sequential)]
public struct MemoryStatus
{
    public uint dwLength;
    public uint dwMemoryLoad;
    public ulong ullTotalPhys;
    public ulong ullAvailPhys;
    public ulong ullTotalPageFile;
    public ulong ullAvailPageFile;
    public ulong ullTotalVirtual;
    public ulong ullAvailVirtual;
}