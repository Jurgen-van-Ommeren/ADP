using System.Diagnostics;
using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.PriorityQueue;

public class PriorityQueueWithArrayTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        AddLijstFloat8001(datasetSorting);
        Peek(datasetSorting);
        Poll(datasetSorting);
    }

    private void AddLijstFloat8001(DatasetSorting datasetSorting)
    {
        //In next loops we add three times LijstFloat8001 (without sizing array)
        //The time is increasing exponential because complexity O(N²)
        
        var priorityQueueFloat = new PriorityQueueWithArray<float>(datasetSorting.LijstFloat8001.Length * 3);
        
        //Warmup
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        priorityQueueFloat.Add(-1);
        
        //Take ~220ms
        ConsoleStopwatch.Start("Adding LijstFloat8001"); 
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueueFloat.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        //Take ~940ms
        ConsoleStopwatch.Start("Adding LijstFloat8001"); 
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueueFloat.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        //Take ~2000ms
        ConsoleStopwatch.Start("Adding LijstFloat8001"); 
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueueFloat.Add(item);
        }
        ConsoleStopwatch.Stop();
    }
    
    private void Peek(DatasetSorting datasetSorting)
    {
        //In next loops we add three times LijstFloat8001 (without sizing array)
        //Between loops we do an Peek, the time of Peek is constant because complexity O(1)
        
        var priorityQueueFloat = new PriorityQueueWithArray<float>(datasetSorting.LijstFloat8001.Length * 3);
        
        //Warmup
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        priorityQueueFloat.Peek();
        
        foreach (var item in datasetSorting.LijstFloat8001)
            priorityQueueFloat.Add(item);
        
        ConsoleStopwatch.Start("Peek 8001");
        priorityQueueFloat.Peek();
        ConsoleStopwatch.Stop();
        
        foreach (var item in datasetSorting.LijstFloat8001)
            priorityQueueFloat.Add(item);

        ConsoleStopwatch.Start("Peek 16002");
        priorityQueueFloat.Peek();
        ConsoleStopwatch.Stop();
        
        foreach (var item in datasetSorting.LijstFloat8001)
            priorityQueueFloat.Add(item);

        ConsoleStopwatch.Start("Peek 24003");
        priorityQueueFloat.Peek();
        ConsoleStopwatch.Stop();
    }
    
    private void Poll(DatasetSorting datasetSorting)
    {
        //In next loops we add three times LijstFloat8001 (without sizing array)
        //Between loops we do an Poll, the time of Peek is linear because complexity O(N)
        
        var priorityQueue = new PriorityQueueWithArray<int>(3_000_000);

        //Warmup
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        priorityQueue.Poll();

        for (int i = 0; i < 1_000_000; i++)
            priorityQueue.Add(i);

        priorityQueue.Poll();
        
        for (int i = 1_000_000; i < 2_000_000; i++)
            priorityQueue.Add(i); 
        
        priorityQueue.Poll();
        
        for (int i = 2_000_000; i < 3_000_000; i++)
            priorityQueue.Add(i); 
        
        priorityQueue.Poll();
    }
}