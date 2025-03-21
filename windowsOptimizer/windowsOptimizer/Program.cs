using System.Threading.Tasks;
using System.Threading;

namespace optmizerTony
{
    class Program()
    {
        public string computerUserName = Environment.UserName; //não está sendo usado pra nada
        public static async Task Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("1. Enable Game Mode(+8gb ram only.) \n" +
                              "2. Disable Xbox Game Bar \n" +
                              "3. Disable Windows Limitations(Internet, Cpu etc.) \n" +
                              "4. Disable Windows services for more ram \n" +
                              "5. Disable Xbox Services \n" +
                              "6. (BROKEN)Disable Windows Securance(Win Defender, virus protection etc.) \n" +
                              "7. Disable Printer, scaners and etc. \n" +
                              "8. (BROKEN)Disable Bluetooth. \n" +
                              "9. Disable Random Programs services\n" +
                              "u. Disable Windows Update! \n" +
                              "t. (TESTING FEATURE) NtSetTimerResolution 1s (16.5s Default)");
                                
            Console.WriteLine("\n Your choice: ");
            char option = char.Parse(Console.ReadLine());

            switch(option)
            {
                case '1':
                    windowsConfigs.configs("gameMode", 1);
                    await Task.Delay(2500);
                    Main([]);
                    break;
                case '2':
                    windowsConfigs.configs("gameBar", 0);
                    await Task.Delay(2500);
                    Main([]);
                    break;
                case '3':
                    windowsConfigs.configs("limitations", 0);
                    await Task.Delay(2500);
                    Main([]);
                    break;
                case '4':
                    servicesPacks.disableServices("windowsForGaming", "Disabled");
                    await Task.Delay(2500);
                    Main([]);
                    break;
                case '5':
                    servicesPacks.disableServices("XboxServices", "Disabled");
                    await Task.Delay(2500);
                    Main([]);
                    break;
                case '6':
                    servicesPacks.disableServices("securancePack", "Disabled");
                    await Task.Delay(2500);
                    Main([]);
                    break;
                case '7':
                    servicesPacks.disableServices("printers&peripherals", "Disabled");
                    await Task.Delay(2500);
                    Main([]);
                    break;
                case '8':
                    servicesPacks.disableServices("bluetoothPacks", "Disabled");
                    await Task.Delay(2500);
                    Main([]);
                    break;
                case '9':
                    servicesPacks.disableServices("programsServices", "Disabled");
                    await Task.Delay(2500);
                    Main([]);
                    break;
                case 't':
                    SetTimerResolution.defineResTime(1000);
                    await Task.Delay(2500);
                    Main([]);
                    break;
                case 'u':
                    servicesPacks.disableServices("windowsUpdate", "Disable");
                    await Task.Delay(2500);
                    Main([]);
                    break;
            }
        }
    }
}