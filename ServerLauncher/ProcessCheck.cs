using System.Diagnostics;
using System.Reflection;
using System.Threading;
using ServerLauncher.Properties;

namespace ServerLauncher;

public class ProcessCheck: IDisposable
{
    private readonly Label _statusLabel;
    private readonly Button _startButton;
    private readonly Button[] _stopButtons;

    private string SettingsPrefix { get; set; }
    private Thread _checkThread;
    private PeriodicTimer Timer { get; set; }

    private Int32 _offlineSince = 0;


    public ProcessCheck(string settingsPrefix, Label statusLabel, Button startButton, Button[] stopButtons)
    {
        _statusLabel = statusLabel;
        _startButton = startButton;
        _stopButtons = stopButtons;
        SettingsPrefix = settingsPrefix;

        _checkThread = new Thread(new ThreadStart(RunProcess));
        _checkThread.Start();

    }
    public Int32 GetUnixTimeStamp()
    {
        return (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
    }

    public async void RunProcess()
    {
        var second = TimeSpan.FromSeconds(1);
        Timer = new PeriodicTimer(second);
        while (await Timer.WaitForNextTickAsync())
        {
            string path = (string) Settings.Default[$"{SettingsPrefix}executablePath"];
            bool autoRestart = (bool) Settings.Default[$"{SettingsPrefix}automaticRestart"];
            int autoRestartTime = (int) Settings.Default[$"{SettingsPrefix}automaticRestartTime"];

            if (path.Length == 0) continue;

            if (GetProcessByFilename(path).Count > 0)
            {
                // Server is online
                _offlineSince = 0; 
                SetControlPropertyThreadSafe(_statusLabel, "ForeColor", Color.Green);
                SetControlPropertyThreadSafe(_statusLabel, "Text", $"Online");

                if (File.Exists(Path.GetDirectoryName(path) + "/start.command"))
                {
                    File.Delete(Path.GetDirectoryName(path) + "/start.command");
                }

                // disable start Button and stop buttons
                SetControlPropertyThreadSafe(_startButton, "Enabled", false);
                foreach (var stopButton in _stopButtons)
                {
                    SetControlPropertyThreadSafe(stopButton, "Enabled", true);
                }
            }
            else
            {
                // disable stop Buttons and enable start button
                SetControlPropertyThreadSafe(_startButton, "Enabled", true);
                foreach (var stopButton in _stopButtons)
                {
                    SetControlPropertyThreadSafe(stopButton, "Enabled", false);
                }

                // server is offline
                if (_offlineSince == 0)
                    _offlineSince = GetUnixTimeStamp();
                SetControlPropertyThreadSafe(_statusLabel, "ForeColor", Color.DarkRed);
                SetControlPropertyThreadSafe(_statusLabel, "Text", $"Offline since {GetTimeDifferenceString(GetUnixTimeStamp() - _offlineSince)}");

                // check if there is a start command
                Console.WriteLine(Path.GetDirectoryName(path));
                int offlineMinutes = (int) Math.Floor((decimal) (GetUnixTimeStamp() - _offlineSince) / 60);
                if (File.Exists(Path.GetDirectoryName(path) + "/start.command") || autoRestart && autoRestartTime <= offlineMinutes)
                {
                    SetControlPropertyThreadSafe(_statusLabel, "ForeColor", Color.Yellow);
                    SetControlPropertyThreadSafe(_statusLabel, "Text", $"Server starting....");

                    // start Server
                    StartProcess(path);
                    _offlineSince = 0;
                }
            }
        }
    }

    public static void StartProcess(string path)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.WorkingDirectory = Path.GetDirectoryName(path) ?? throw new InvalidOperationException();
        startInfo.FileName = path;
        Process.Start(startInfo);
    }

    public static void ShutDownProcess(string path, bool killProcess)
    {
        List<Process> processes = GetProcessByFilename(path);
        if (killProcess)
        {
            processes.ForEach((process => process.Kill(true)));
        }
        else
        {
            File.Create(Path.GetDirectoryName(path) + "/stop.command");
        }
    }

    private string GetTimeDifferenceString(int time)
    {
        if (time <= 60)
        {
            return $"{time} seconds";
        }
        else
        {
            int minutes = (int) time / 60;
            int restSeconds = (int) time % 60;

            return $"{minutes} minute(s), {restSeconds} seconds";
        }
    }

    private static List<Process> GetProcessByFilename(string filename)
    {
        List<Process> processes = new List<Process>();

        foreach (var process in Process.GetProcesses())
        {
            try
            {
                if (process.MainModule.FileName == filename)
                {
                    processes.Add(process);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        return processes;
    }


    public void Dispose()
    {
        _checkThread.Interrupt();
    }

    private delegate void SetControlPropertyThreadSafeDelegate(
        Control control,
        string propertyName,
        object propertyValue);

    public static void SetControlPropertyThreadSafe(
        Control control,
        string propertyName,
        object propertyValue)
    {
        if (control.InvokeRequired)
        {
            control.Invoke(new SetControlPropertyThreadSafeDelegate
                    (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
        }
        else
        {
            control.GetType().InvokeMember(
                propertyName,
                BindingFlags.SetProperty,
                null,
                control,
                new object[] { propertyValue });
        }
    }
}