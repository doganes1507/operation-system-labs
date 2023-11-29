using static OperationSystemsLabs.WinApi.WinApiMethods;

namespace OperationSystemsLabs.LabPages.Lab2;

public partial class Lab2
{
    public Lab2()
    {
        InitializeComponent();

        DisplayCurrentProcessInfo();
        ModulePropertyType.ItemsSource = new List<string> { "Имя модуля", "Путь к модулю" };
    }

    private void GetModuleInfo_OnClicked(object sender, EventArgs e)
    {
        var input = ModuleProperty.Text;

        var moduleHandle = LoadLibrary(input);

        if (moduleHandle != IntPtr.Zero)
        {
            DisplayAlert("Результат", $"Дескриптор модуля: {moduleHandle}", "OK");
        }
        else
        {
            DisplayAlert("Ошибка", "Модуль не найден", "OK");
            return;
        }

        switch (ModulePropertyType.SelectedItem)
        {
            case "Имя модуля":
                DisplayModulePath(moduleHandle);
                break;

            case "Путь к модулю":
                DisplayModuleName(moduleHandle);
                break;

            default:
                DisplayAlert("Ошибка", "Выберите один из предложенных вариантов", "OK");
                break;
        }
    }

    private void DisplayCurrentProcessInfo()
    {
        var currentProcessId = GetCurrentProcessId();
        var currentProcessHandle = GetCurrentProcess();
        var success = DuplicateHandle(
            currentProcessHandle,
            currentProcessHandle,
            currentProcessHandle,
            out var duplicateHandle,
            0,
            false,
            0
        );

        var currentProcessHandleCopy = OpenProcess(0x1F0FFF, false, currentProcessId);

        CurrentProcessId.Text = currentProcessId.ToString();
        CurrentProcessPseudoDescriptor.Text = currentProcessHandle.ToString();
        CurrentProcessDescriptor.Text = duplicateHandle.ToString();
        CurrentProcessDescriptorCopy.Text = currentProcessHandleCopy.ToString();

        CloseHandle(duplicateHandle);
        CloseHandle(currentProcessHandleCopy);
    }

    private void DisplayModulePath(IntPtr moduleHandle)
    {
        var buffer = new char[260];
        var length = GetModuleFileName(moduleHandle, buffer, buffer.Length);

        if (length > 0)
        {
            var modulePath = new string(buffer, 0, length);
            DisplayAlert("Результат", $"Путь к модулю: {modulePath}", "OK");
        }
        else
        {
            DisplayAlert("Ошибка", "Ошибка при получении пути к модулю", "OK");
        }
    }

    private void DisplayModuleName(IntPtr moduleHandle)
    {
        var buffer = new char[260];
        var length = GetModuleFileName(moduleHandle, buffer, buffer.Length);

        if (length > 0)
        {
            var moduleName = Path.GetFileName(new string(buffer, 0, length));
            DisplayAlert("Результат", $"Имя модуля: {moduleName}", "OK");
        }
        else
        {
            DisplayAlert("Ошибка", "Ошибка при получении имени модуля", "OK");
        }
    }

    private void NavigateToProcessInfosPage_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProcessInfosPage());
    }
}