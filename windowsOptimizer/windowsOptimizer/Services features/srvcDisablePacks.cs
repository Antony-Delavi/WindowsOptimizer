using System.Diagnostics;

public static partial class srvcDisablePacks
{
    public static void disableServices(string howPack, string iniType)
    {
        switch(howPack)
        {
            case "winSecurePack":
                Process.Start(new ProcessStartInfo //secure
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"Set-Service -Name 'Fax' -StartupType {iniType}" +
                                $"Set-Service -Name 'Spooler' -StartupType {iniType}" +
                                $"Set-Service -Name 'WSerach' -StartupType {iniType}" +
                                $"Set-Service -Name 'icssvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'DiagTrack' -StartupType {iniType}" +
                                $"Set-Service -Name 'TabletInputService' -StartupType {iniType}" +
                                $"Set-Service -Name 'RemoteRegistry' -StartupType {iniType}" +
                                $"Set-Service -Name 'wisvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'WbioSrvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'TrkWks' -StartupType {iniType}" +
                                $"Set-Service -Name 'RetailDemo' -StartupType {iniType}" +
                                $"Set-Service -Name 'AJRouter' -StartupType {iniType}" +
                                $"Set-Service -Name 'TermsService' -StartupType {iniType}" +
                                $"Set-Service -Name 'MapsBroker' -StartupType {iniType}" +
                                $"Set-Service -Name 'SCardSvr' -StartupType {iniType}" +
                                $"Set-Service -Name 'WFDSConMgrSvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'MSiSCSI' -StartupType {iniType}" +
                                $"Set-Service -Name 'WMPNetworkSvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'PhoneSvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'WPCSvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'NvTelemetryContainer' -StartupType {iniType}" +
                                $"Set-Service -Name 'CDPUserSvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'stisvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'CscService' -StartupType {iniType}" +
                                $"Set-Service -Name 'Rasman' -StartupType {iniType}" +
                                $"Set-Service -Name 'WMPNetworkSvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'WMPNetworkSvc' -StartupType {iniType}" +
                                $"Set-Service -Name 'WMPNetworkSvc' -StartupType {iniType}\"" ,
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "XboxServices":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"Set-Service -Name 'XboxGipSvc' -StartupType {iniType}; " +
                                $"Set-Service -Name 'XblAuthManager' -StartupType {iniType}; " +
                                $"Set-Service -Name 'XblGameSave' -StartupType {iniType}; " +
                                $"Set-Service -Name 'XblNetAuthManager' -StartupType {iniType}; " +
                                $"Set-Service -Name 'XboxNetApiSvc' -StartupType {iniType}; " +
                                $"Set-Service -Name 'BcastDVRUserService' -StartupType {iniType}\"",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "securancePack":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\" /v DisableAntiSpyware /t REG_DWORD /d 1 /f; " +
                                $"reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender SmartScreen\" /v EnableSmartScreen /t REG_DWORD /d 0 /f; " +
                                $"Set-Service -Name 'smartscreen' -StartupType {iniType}; " +
                                $"Set-Service -Name 'UMFD-0' -StartupType {iniType}; " +
                                $"Set-Service -Name 'AppIDSvc' -StartupType {iniType}; " +
                                $"Set-Service -Name 'napagent' -StartupType {iniType}; " +
                                $"Set-Service -Name 'WinRM' -StartupType {iniType};\"",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "programsServices":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"Set-Service -Name 'AdobeUpdateService' -StartupType {iniType}; " +
                                $"Set-Service -Name 'gupdate' -StartupType {iniType}; " +
                                $"Set-Service -Name 'gupdatem' -StartupType {iniType}; " +
                                $"Set-Service -Name 'MozillaMaintenance' -StartupType {iniType}; " +
                                $"Set-Service -Name 'Steam Client Service\t' -StartupType {iniType}; " +
                                $"Set-Service -Name 'NvContainerLocalSystem' -StartupType {iniType}; " +
                                $"Set-Service -Name 'AMD External Events Utility' -StartupType {iniType}; " +
                                $"Set-Service -Name 'googledrivesync' -StartupType {iniType}; " +
                                $"Set-Service -Name 'DropboxUpdate' -StartupType {iniType}; " +
                                $"Set-Service -Name 'Razer Game Scanner' -StartupType {iniType}; " +
                                $"Set-Service -Name 'LGHUBUpdaterService' -StartupType {iniType}; " +
                                $"Set-Service -Name 'OneSyncSvc' -StartupType {iniType};\"",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "printers&peripherals":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"Set-Service -Name 'Spooler' -StartupType {iniType}; " +
                                $"Set-Service -Name 'DmEnrollmentSvc' -StartupType {iniType}; " +
                                $"Set-Service -Name 'NfcSvc' -StartupType {iniType}; " +
                                $"Set-Service -Name 'SCardSvr' -StartupType {iniType}; " +
                                $"Set-Service -Name 'SCardSvr' -StartupType {iniType}; " +
                                $"Set-Service -Name 'WbioSrvc' -StartupType {iniType}; " +
                                $"Set-Service -Name 'XboxGipSvc' -StartupType {iniType}; " +
                                $"Set-Service -Name 'stisvc' -StartupType {iniType}\"",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "bluetoothPacks":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"Set-Service -Name 'bthserv' -StartupType {iniType}; " +
                                $"Set-Service -Name 'BTAGService' -StartupType {iniType}; " +
                                $"Set-Service -Name 'BthUserService' -StartupType {iniType}\"",
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
        } 
    }
}