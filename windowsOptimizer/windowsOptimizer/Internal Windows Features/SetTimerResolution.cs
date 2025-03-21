using System;
using System.Runtime.InteropServices;
public static partial class SetTimerResolution
{
    [DllImport("ntdll.dll", SetLastError = true)]
    public static extern int NtSetTimerResolution(uint desiredResolution, bool setResolution, ref uint currentResolution);

    public static bool SetTimerInMiliseconds(uint desiredResolution)
    {
        uint currentResolution = 0;

        int result = NtSetTimerResolution(desiredResolution, true, ref currentResolution);

        if (result == 0)
        {
            Console.WriteLine($"New Resolution is {desiredResolution} microsseconds.");
            return true; 
        }
        else
        {
            Console.WriteLine("ERRORRR");
            return false; 
        }
    }
    public static void defineResTime(uint desiredResolution)
    {
        SetTimerInMiliseconds(desiredResolution);

    }
}

//Este código todo altera o NtSetTimerResolution do windows, o padrão é 16.5ms
//e o programa altera ele para 1ms, aumentar o gasto de bateria e etc
//mas aumenta o desempenho em alguns jogos, principalmente em jogos fps e no carregamento de outros
//jogos, não é muito documentado mas funciona! ;)