using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.PriorityQueue;

public class PriorityQueueWithArrayTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        var sw = new ConsoleStopwatch();
        
        var priorityQueueFloat = new PriorityQueueWithArray<float>(24003);
        
        //Take ~220ms
        sw.Start("Adding LijstFloat8001"); 
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueueFloat.Add(item);
        }
        sw.Stop();
        
        //Take ~640ms
        sw.Start("Adding LijstFloat8001"); 
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueueFloat.Add(item);
        }
        sw.Stop();
        
        //Take ~1640ms
        sw.Start("Adding LijstFloat8001"); 
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueueFloat.Add(item);
        }
        sw.Stop();
        
        var priorityQueue = new PriorityQueueWithArray<int>();
        
        sw.Start("Adding 1_000"); 
        for (int i = 1_000; i > 0; i--)
        {
            priorityQueue.Add(i);
        }
        sw.Stop();
        
        priorityQueue = new PriorityQueueWithArray<int>();
        
        sw.Start("Adding 2_000"); 
        for (int i = 2_000; i > 0; i--)
        {
            priorityQueue.Add(i);
        }
        sw.Stop();
        
        priorityQueue = new PriorityQueueWithArray<int>();
        
        sw.Start("Adding 10_000"); 
        for (int i = 10_000; i > 0; i--)
        {
            priorityQueue.Add(i);
        }
        sw.Stop();

        sw.Start("Peeking 1_000");
        for (int i = 1_000; i > 0; i--)
        {
            var peek = priorityQueue.Peek();
        }
        sw.Stop();
        
        sw.Start("Peeking 2_000");
        for (int i = 2_000; i > 0; i--)
        {
            var peek = priorityQueue.Peek();
        }
        sw.Stop();
        
        sw.Start("Peeking 100_000");
        for (int i = 100_000; i > 0; i--)
        {
            var peek = priorityQueue.Peek();
        }
        sw.Stop();

        sw.Start("Polling 1_000"); 
        for (int i = 1_000; i > 0; i--)
        {
            priorityQueue.Poll();
        }
        sw.Stop();
        
        priorityQueue = new PriorityQueueWithArray<int>();
        
        for (int i = 10_000; i > 0; i--)
        {
            priorityQueue.Add(i);
        }
        
        sw.Start("Polling 2_000"); 
        for (int i = 2_000; i > 0; i--)
        {
            priorityQueue.Poll();
        }
        sw.Stop();
        
        priorityQueue = new PriorityQueueWithArray<int>();
        
        for (int i = 10_000; i > 0; i--)
        {
            priorityQueue.Add(i);
        }
        
        sw.Start("Polling 5_000"); 
        for (int i = 5_000; i > 0; i--)
        {
            priorityQueue.Poll();
        }
        sw.Stop();
    }
}