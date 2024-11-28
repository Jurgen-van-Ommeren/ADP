using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.Deque;

public class DequeTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        var deque = new Deque<string>();

        ConsoleStopwatch.Start("Adding 1_000_000"); 
        for (int i = 0; i < 500_000; i++)
        {
            deque.InsertLeft(i.ToString());
            deque.InsertRight(i.ToString());
        }
        ConsoleStopwatch.Stop();
        
        deque = new Deque<string>();
        
        ConsoleStopwatch.Start("Adding 1_000_000"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            deque.InsertLeft(i.ToString());
            deque.InsertRight(i.ToString());
        }
        ConsoleStopwatch.Stop();
        
        deque = new Deque<string>();
        
        ConsoleStopwatch.Start("Adding 10_000_000"); 
        for (int i = 0; i < 5_000_000; i++)
        {
            deque.InsertLeft(i.ToString());
            deque.InsertRight(i.ToString());
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Removing 10_000_000"); 
        for (int i = 0; i < 5_000_000; i++)
        {
            deque.DeleteLeft();
            deque.DeleteRight();
        }
        ConsoleStopwatch.Stop();
    }
}