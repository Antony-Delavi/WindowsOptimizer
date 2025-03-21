using System;
using System.Runtime.InteropServices;
public static partial class ntResolution
{
    // Importação da função NtSetTimerResolution
    [DllImport("ntdll.dll", SetLastError = true)]
    public static extern int NtSetTimerResolution(uint desiredResolution, bool setResolution, ref uint currentResolution);

    // Função para modificar apenas a resolução do temporizador
    public static bool SetTimerResolution(uint desiredResolution)
    {
        uint currentResolution = 0;

        // Chama NtSetTimerResolution para alterar a resolução
        int result = NtSetTimerResolution(desiredResolution, true, ref currentResolution);

        // Se a função retornou 0, significa sucesso
        if (result == 0)
        {
            Console.WriteLine($"Resolução do temporizador ajustada para {desiredResolution} microssegundos.");
            return true; // Sucesso
        }
        else
        {
            Console.WriteLine("Falha ao ajustar a resolução do temporizador.");
            return false; // Falha
        }
    }
    public static void defineRestime(uint desiredResolution)
    {
        SetTimerResolution(desiredResolution);

    }
}