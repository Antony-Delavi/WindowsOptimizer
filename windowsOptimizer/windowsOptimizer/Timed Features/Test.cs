using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
public static partial class Test
{
    public static async Task TestAsync()
    {
        var segundos30 = TimeSpan.FromSeconds(30);
        using var cancelar = new CancellationTokenSource();

        try
        {
            await Task.Run(async () =>
            {
                while (!cancelar.Token.IsCancellationRequested)
                {
                    try
                    {
                        var processo = Process.Start(new ProcessStartInfo
                        {
                            FileName = "powershell.exe",
                            Arguments = "Stop-Process -Name mspaint -Force",
                            Verb = "runas"
                        });

                        processo?.WaitForExit();
                        await Task.Delay(1000, cancelar.Token);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                }
            }, cancelar.Token);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operação cancelada.");
        }
    }

}

//estou testando isso, não sei se vou por oficialmente como uma nova feature, talvez mais no futuro