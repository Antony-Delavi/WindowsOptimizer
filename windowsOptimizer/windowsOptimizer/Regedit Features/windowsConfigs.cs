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
        }
    }
}