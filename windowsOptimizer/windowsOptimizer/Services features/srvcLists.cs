using System.Diagnostics;
public static partial class srvcLists
{
    public static void disableWhoService(string serviceName, string inicializationType)
    {
        switch(serviceName)
        { 
            case "SecondaryLogon":
                Process.Start(new ProcessStartInfo //separated
                {
                    FileName = "powershell.exe",
                    Arguments = $"Set-Service -Name \"seclogon\" -StartupType {inicializationType}",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "Bluetooth":
                Process.Start(new ProcessStartInfo //Separated
                {
                    FileName = "powershell.exe",
                    Arguments = $"Set-Service -Name \"bthserv\" -StartupType {inicializationType}",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "EdgeUpdate":
                Process.Start(new ProcessStartInfo //separated // Edge
                {
                    FileName = "powershell.exe",
                    Arguments = $"Set-Service -Name \"edgeupdate\" -StartupType {inicializationType}",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;

            // DANGEROUS SERVICES //
            // DANGEROUS SERVICES //

            case "windowsUpdate":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"Set-Service -Name \"wuauserv\" -StartupType {inicializationType}",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "Superfetch":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"Set-Service -Name \"SysMain\" -StartupType {inicializationType}",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "ErrorReport":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"Set-Service -Name \"WerSvc\" -StartupType {inicializationType}",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "Ipv6":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"Set-Service -Name \"iphlpsvc\" -StartupType {inicializationType}",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "Diagnostic":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"Set-Service -Name \"DPS\" -StartupType {inicializationType}",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "ProgramComp":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"Set-Service -Name \"PcaSvc\" -StartupType {inicializationType}",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "GeolocationSvc":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"Set-Service -Name \"lfsvc\" -StartupType {inicializationType}",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
        }
    }
}   