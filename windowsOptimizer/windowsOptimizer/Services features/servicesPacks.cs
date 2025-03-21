using System.Diagnostics;

public static partial class servicesPacks
{
    public static void disableServices(string howPack, string iniType)
    {
        switch(howPack)
        {
            case "windowsForGaming": //Serviços seguros/inúteis para desativar 
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"Set-Service -Name 'Fax' -StartupType {iniType}" +
                                $"Set-Service -Name 'Spooler' -StartupType {iniType}" + //Manages the print queue for printers connected to the computer.
                                $"Set-Service -Name 'WSerach' -StartupType {iniType}" + // Indexes files, emails, and other content to speed up Windows searches.
                                $"Set-Service -Name 'icssvc' -StartupType {iniType}" + // Allows internet connection sharing between devices on a network.
                                $"Set-Service -Name 'DiagTrack' -StartupType {iniType}" + //Collects diagnostic data and sends it to Microsoft to improve Windows.
                                $"Set-Service -Name 'TabletInputService' -StartupType {iniType}" + // Supports virtual keyboards and handwriting recognition.
                                $"Set-Service -Name 'RemoteRegistry' -StartupType {iniType}" + // Allows remote editing of the Windows Registry.
                                $"Set-Service -Name 'wisvc' -StartupType {iniType}" + // Manages participation in the Windows Insider program (testing versions of Windows).
                                $"Set-Service -Name 'WbioSrvc' -StartupType {iniType}" + // Supports biometric devices (fingerprint readers, facial recognition).
                                $"Set-Service -Name 'TrkWks' -StartupType {iniType}" + // Maintains links between moved files across a network.
                                $"Set-Service -Name 'RetailDemo' -StartupType {iniType}" + // Enables the retail demo mode for store displays.
                                $"Set-Service -Name 'AJRouter' -StartupType {iniType}" + //  Supports AllJoyn protocol for IoT and automation devices.
                                $"Set-Service -Name 'TermsService' -StartupType {iniType}" + // Enables remote connections via Remote Desktop Protocol (RDP).
                                $"Set-Service -Name 'MapsBroker' -StartupType {iniType}" + // Manages the download and updating of offline maps.
                                $"Set-Service -Name 'SCardSvr' -StartupType {iniType}" + // Supports smart card authentication.
                                $"Set-Service -Name 'WFDSConMgrSvc' -StartupType {iniType}" + // Supports Wi-Fi Direct connections between devices.
                                $"Set-Service -Name 'MSiSCSI' -StartupType {iniType}" + // Supports connections to iSCSI storage devices.
                                $"Set-Service -Name 'WMPNetworkSvc' -StartupType {iniType}" + // Allows Windows Media Player to share media over a network.
                                $"Set-Service -Name 'PhoneSvc' -StartupType {iniType}" + // Manages phone call features and connectivity with mobile devices.
                                $"Set-Service -Name 'WPCSvc' -StartupType {iniType}" + // Manages Windows Parental Controls features.
                                $"Set-Service -Name 'NvTelemetryContainer' -StartupType {iniType}" + // Collects NVIDIA usage and diagnostic data.
                                $"Set-Service -Name 'CDPUserSvc' -StartupType {iniType}" + // Supports communication between connected devices.
                                $"Set-Service -Name 'stisvc' -StartupType {iniType}" + // Supports scanners and digital cameras.
                                $"Set-Service -Name 'CscService' -StartupType {iniType}" + //  Manages cached files for offline access.
                                $"Set-Service -Name 'Rasman' -StartupType {iniType}" + //  Manages VPN and dial-up connections.
                                $"Set-Service -Name 'WMPNetworkSvc' -StartupType {iniType}\"", // Enables Windows Media Player to share media across a network.
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "XboxServices": //Serviços do Xbox, muita sobreposição, diminuindo o desempenho
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"Set-Service -Name 'XboxGipSvc' -StartupType {iniType}; " + // Manages Xbox accessories like controllers and adaptive devices.
                                $"Set-Service -Name 'XblAuthManager' -StartupType {iniType}; " + // Handles authentication for Xbox Live services on Windows.
                                $"Set-Service -Name 'XblGameSave' -StartupType {iniType}; " + //  Synchronizes saved game data with Xbox Live Cloud.
                                $"Set-Service -Name 'XblNetAuthManager' -StartupType {iniType}; " + // Manages network authentication for Xbox Live multiplayer.
                                $"Set-Service -Name 'XboxNetApiSvc' -StartupType {iniType}; " + // Provides networking support for Xbox Live features.
                                $"Set-Service -Name 'BcastDVRUserService' -StartupType {iniType}\"", //Enables background recording of gameplay and broadcasting features in Game Bar.
                    Verb = "runas",
                    UseShellExecute = true
                });
                break;
            case "securancePack": //windows defender e etc, não é muito seguro de desativar
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe", //Não funciona
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
            case "programsServices": //serviços em segundo plano de programas de terceiros Ex: Adobe, Amd, Nvidia
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
            case "printers&peripherals": //Impressorar e periféricos "Inúteis", aqui tem o controle do xbox também
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
            case "bluetoothPacks": //desabilitar completamente o bluetooth (Não funciona ;( )
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
            case "windowsUpdate":
                Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"net stop wuauserv;" +
                                $"Set-Service -Name 'UsoSvc' -StartupType {iniType};" +
                                $"net stop WaaSMedicSvc;" +
                                $"Set-Service -Name 'BITS' -StartupType {iniType};" +
                                $"net stop CryptSvc;" +
                                $"Set-Service -Name 'CryptSvc' -StartupType {iniType};" +
                                $"net stop msiserver;" +
                                $"Set-Service -Name 'msiserver' -StartupType {iniType}\";",
                    Verb = "runas",
                    UseShellExecute = true
                                
                });
                break;
        } 
    }
}