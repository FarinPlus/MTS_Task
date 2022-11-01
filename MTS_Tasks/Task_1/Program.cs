using System.Diagnostics;
class Programm
{
    static void Main(string[] args)
    {
        try
        {
            //FailProcess2();
            //FailProcess1();
            FailProcess();
        }
        catch { }

        Console.WriteLine("Failed to fail process!");
        Console.ReadKey();
    }

    static void FailProcess()
    {
        Environment.Exit(0);
    }

    static void FailProcess1()
    {
        Process.GetCurrentProcess().Kill();
    }
    static void FailProcess2()
    {
        Process.GetProcessById(Process.GetCurrentProcess().Id).Kill();
    }
}
