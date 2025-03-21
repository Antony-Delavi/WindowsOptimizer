using System;
using System.Runtime.InteropServices;
public static partial class ntResolution
{
    [DllImport("ntdll.dll", SetLastError = true)]
    public static extern int NtSetTimerResolution(uint desiredResolution, bool setResolution, ref uint currentResolution);

    public static bool SetTimerResolution(uint desiredResolution)
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
    public static void defineRestime(uint desiredResolution)
    {
        SetTimerResolution(desiredResolution);

    }
}