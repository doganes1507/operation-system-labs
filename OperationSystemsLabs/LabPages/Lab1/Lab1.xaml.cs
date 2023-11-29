using System.Runtime.InteropServices;
using static OperationSystemsLabs.WinApi.WinApiMethods;
using System.Text;
using OperationSystemsLabs.WinApi.Structures;

namespace OperationSystemsLabs.LabPages.Lab1;

public partial class Lab1
{
    public Lab1()
    {
        InitializeComponent();
    }
    
    private void DisplayComputerNameButton_OnClicked(object sender, EventArgs e)
    {
        var bufferSize = 256;
        var computerName = new StringBuilder(bufferSize);
        
        GetComputerName(computerName, ref bufferSize);
        
        DisplayAlert("Имя компьютера", computerName.ToString(), "OK");
    }

    private void DisplayUserNameButton_OnClicked(object sender, EventArgs e)
    {
        var bufferSize = 256;
        var userName = new StringBuilder(bufferSize);

        GetUserName(userName, ref bufferSize);

        DisplayAlert("Имя пользователя", userName.ToString(), "OK");
    }

    private void DisplayWindowsDirectoryButton_OnClicked(object sender, EventArgs e)
    {
        var bufferSize = 260;
        var windowsDirectory = new StringBuilder(bufferSize);

        GetWindowsDirectory(windowsDirectory, ref bufferSize);

        DisplayAlert("Путь к каталогу Windows", windowsDirectory.ToString(), "OK");
    }

    private void DisplayOsVersionButton_OnClicked(object sender, EventArgs e)
    {
        var osVersionInfo = new OsVersionInfoEx
        {
            dwOSVersionInfoSize = Marshal.SizeOf(typeof(OsVersionInfoEx))
        };

        GetVersionEx(ref osVersionInfo);

        DisplayAlert("Версия операционной системы",
            osVersionInfo.dwMajorVersion + "." + osVersionInfo.dwMinorVersion, "OK");
    }

    private void DisplayScreenWidthButton_OnClicked(object sender, EventArgs e)
    {
        var screenWidth = GetSystemMetrics(0);
        DisplayAlert("Ширина Экрана", screenWidth + " px", "OK");
    }

    private void DisplayScreenHeightButton_OnClicked(object sender, EventArgs e)
    {
        var screenHeight = GetSystemMetrics(1);
        DisplayAlert("Высота экрана", screenHeight + " px", "OK");

    }

    private void DisplayCursorSizeButton_OnClicked(object sender, EventArgs e)
    {
        SystemParametersInfo(0x2016, 0, out var cursorSize, 0);
        DisplayAlert("Размер курсора", cursorSize.ToString(), "OK");
    }

    private void DisplayDoubleClickTimeButton_OnClicked(object sender, EventArgs e)
    {
        SystemParametersInfo(0x0020, 0, out var doubleClickTime, 0);
        DisplayAlert("Скорость двойного щелчка мышью", doubleClickTime.ToString(), "OK");
    }

    private void DisplaySystemTimeButton_OnClicked(object sender, EventArgs e)
    {
        GetSystemTime(out var systemTime);
        DisplayAlert("Системное время", systemTime.wHour + 3 + ":" + systemTime.wMinute + ":" + systemTime.wSecond, "OK");
    }

    private void DisplayTimeSinceStartupButton_OnClicked(object sender, EventArgs e)
    {
        var milliseconds = GetTickCount();

        var hours = milliseconds / 3_600_000;
        var minutes = (milliseconds % 3_600_000) / 60_000;
        var seconds = ((milliseconds % 3_600_000) % 60_000) / 1000;

        DisplayAlert("Время, прошедшее с запуска системы", hours + " часов " + minutes + " минут " + seconds + " секунд",
            "OK");
    }

    private void StartPythonButton_OnClicked(object sender, EventArgs e)
    {
        const string programPath = @"C:\Users\dogan\AppData\Local\Programs\Python\Python311\python.exe";
        ShellExecute(IntPtr.Zero, "open", programPath, null, null, 1);
    }

    private void DisplayTotalRamCapacityButton_OnClicked(object sender, EventArgs e)
    {
        var memoryStatus = new MemoryStatus
        {
            dwLength = (uint)Marshal.SizeOf(typeof(MemoryStatus))
        };

        GlobalMemoryStatus(out memoryStatus);

        DisplayAlert("Общий объем оперативной памяти", memoryStatus.ullTotalPhys / 1048576 + " MB", "OK");
    }

    private void DisplayProcessorCountButton_OnClicked(object sender, EventArgs e)
    {
        GetSystemInfo(out var systemInfo);
        DisplayAlert("Количество потоков процессора", systemInfo.dwNumberOfProcessors.ToString(), "OK");
    }
}