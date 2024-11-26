using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.Deque;

public class DequeTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        var sw = new ConsoleStopwatch();
        
        var deque = new Deque<string>();

        sw.Start("Adding 1_000_000"); 
        for (int i = 0; i < 500_000; i++)
        {
            deque.InsertLeft(i.ToString());
            deque.InsertRight(i.ToString());
        }
        sw.Stop();
        
        deque = new Deque<string>();
        
        sw.Start("Adding 2_000_000"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            deque.InsertLeft(i.ToString());
            deque.InsertRight(i.ToString());
        }
        sw.Stop();
        
        deque = new Deque<string>();
        
        sw.Start("Adding 10_000_000"); 
        for (int i = 0; i < 5_000_000; i++)
        {
            deque.InsertLeft(i.ToString());
            deque.InsertRight(i.ToString());
        }
        sw.Stop();
        
        sw.Start("Removing 10_000_000"); 
        for (int i = 0; i < 5_000_000; i++)
        {
            deque.DeleteLeft();
            deque.DeleteRight();
        }
        sw.Stop();
    }
}