using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.PriorityQueue;

public class PriorityQueueTests
{
    public void Run(DatasetSorting datasetSorting)
    {
        var priorityQueue = new PriorityQueue<float>();
        
        
        //takes 1764506 ticks
        ConsoleStopwatch.Start("adding LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueue.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        //takes 13145 ticks
        //complexity = 1: because there are no loops, the time it takes to take the first item out of the list doesn't change when the list is longer.
        ConsoleStopwatch.Start("polling LijstFloat8001");
        for (int i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        {
            priorityQueue.Poll();
        }
        ConsoleStopwatch.Stop();
    }
}