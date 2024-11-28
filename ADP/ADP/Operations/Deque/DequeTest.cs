using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.Deque;

public class DequeTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        Insert(datasetSorting);
        Delete(datasetSorting);
    }

    private void Insert(DatasetSorting datasetSorting)
    {
        //In next loops we add three times 1_000_000
        //Inserting takes the same time because InsertLeft and InsertRight is constant because complexity O(1)
        
        var deque = new Deque<int>();
        
        //Warmup
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        deque.InsertLeft(-1);
        deque.InsertRight(1);
        
        ConsoleStopwatch.Start("Inserting 1_000_000 left"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            deque.InsertLeft(i);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Inserting 1_000_000 right"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            deque.InsertRight(i);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Inserting 1_000_000 left"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            deque.InsertLeft(i);
        }
        ConsoleStopwatch.Stop();
    }
    
    private void Delete(DatasetSorting datasetSorting)
    {
        //In next loops we delete three times 1_000_000
        //Deleting takes the same time because DeleteLeft and DeleteRight is constant because complexity O(1)
        
        var deque = new Deque<int>();
        
        //Warmup
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        deque.DeleteLeft();
        deque.DeleteRight();
        
        for (int i = 0; i < 3_000_000; i++)
            deque.InsertLeft(i);
        
        ConsoleStopwatch.Start("Deleting 1_000_000 left"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            deque.DeleteLeft();
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Deleting 1_000_000 right"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            deque.DeleteRight();
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Deleting 1_000_000 left"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            deque.DeleteLeft();
        }
        ConsoleStopwatch.Stop();
    }
}