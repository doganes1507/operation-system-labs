using System.Runtime.InteropServices;

namespace OperationSystemsLabs.WinApi.Structures;

[StructLayout(LayoutKind.Sequential)]
public struct ThreadEntry32
{
    public uint dwSize;
    public uint cntUsage;
    public uint th32ThreadID;
    public uint th32OwnerProcessID;
    public int tpBasePri;
    public int tpDeltaPri;
    public uint dwFlags;
}