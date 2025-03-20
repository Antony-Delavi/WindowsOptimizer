using System.Diagnostics;

public static partial class windowsConfigs
{
    public static void configs(string optionConfig, int onof)
    {
        switch (optionConfig)
        {
            case "gameMode":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\GameBar\" /v AllowAutoGameMode /t REG_DWORD /d {onof} /f; " +
                                $"reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\GameBar\" /v AutoGameModeEnabled /t REG_DWORD /d {onof} /f;\"",
                    Verb = "runas"
                });
                break;
            case "gameBar":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR\" /v AppCaptureEnabled /t REG_DWORD /d {onof} /f; " +
                                $"reg add \"HKEY_CURRENT_USER\\System\\GameConfigStore\" /v GameDVR_Enabled /t REG_DWORD /d {onof} /f;\"",
                    Verb = "runas"
                });
                break;
            case "limitations":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\" /v NetworkThrottlingIndex /t REG_DWORD /d ffffffff /f;" +
                                $"reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl\" /v Win32PrioritySeparation /t REG_DWORD /d 38 /f;" +
                                $"reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HidUsb\" /v FlipFlopWheel /t REG_DWORD /d 0 /f;" +
                                $"reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HidUsb\" /v FlipFlopHScroll /t REG_DWORD /d 0 /f;" +
                                $"reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Psched\" /v NonBestEffortLimit /t REG_DWORD /d 0 /f;" +
                                $"reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters\" /v EnablePrefetcher /t REG_DWORD /d 3 /f;" +
                                $"reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters\" /v EnableSuperfetch /t REG_DWORD /d 0 /f;" +
                                $"sc stop SysMain & sc config SysMain start=disabled;" +
                                $"sc stop DiagTrack & sc config DiagTrack start=disabled;" +
                                $"sc stop dmwappushservice & sc config dmwappushservice start=disabled;" +
                                $"reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\" /v SystemResponsiveness /t REG_DWORD /d 0 /f;\"",
                    Verb = "runas"
                });
                break;
        }
    }
}