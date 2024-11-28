using System.Diagnostics;

namespace ADP.Testing;

public static class ConsoleStopwatch
{
    private static Stopwatch _stopwatch;
    private static string _title;
    
    public static Stopwatch Start(string title)
    {
        _stopwatch = new Stopwatch();
        _stopwatch.Start();

        _title = title;

        return _stopwatch;
    }

    public static void Stop()
    {
        _stopwatch.Stop();
        System.Console.WriteLine($"{_title} took {_stopwatch.ElapsedTicks / 100} ticks.");
    }
}