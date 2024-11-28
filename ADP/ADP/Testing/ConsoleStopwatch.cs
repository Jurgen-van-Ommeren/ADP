using System.Diagnostics;

namespace ADP.Testing;

public static class ConsoleStopwatch
{
    private static Stopwatch _stopwatch;
    private static string _title;
    
    public static void Start(string title)
    {
        _stopwatch = new Stopwatch();
        _stopwatch.Start();

        _title = title;
    }

    public static void Stop()
    {
        System.Console.WriteLine($"{_title} took {_stopwatch.ElapsedTicks} ticks.");
        _stopwatch.Stop();
    }
}