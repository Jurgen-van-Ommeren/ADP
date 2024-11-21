using System.Diagnostics;

namespace ADP.Testing;

public class ConsoleStopwatch
{
    private Stopwatch _stopwatch;
    private string _title;
    
    public void Start(string title)
    {
        _stopwatch = new Stopwatch();
        _stopwatch.Start();

        _title = title;
    }

    public void Stop()
    {
        System.Console.WriteLine($"{_title} took {_stopwatch.ElapsedMilliseconds} ms.");
        _stopwatch.Stop();
    }
}