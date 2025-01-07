using System.Diagnostics;

namespace ADP.Testing;

public static class ConsoleStopwatch
{
    private static readonly Stopwatch _stopwatch = new();
    private static string _title;
    
    public static void Start(string title)
    {
        _stopwatch.Restart();

        _title = title;
    }

    public static void Stop()
    {
        _stopwatch.Stop();
        System.Console.WriteLine($"{_title} took {_stopwatch.ElapsedTicks} ticks.");
    }

    public static Stopwatch GetStopwatch()
    {
        return _stopwatch;
    }
}