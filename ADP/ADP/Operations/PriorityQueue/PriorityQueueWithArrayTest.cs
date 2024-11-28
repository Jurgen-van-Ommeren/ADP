using System.Diagnostics;
using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.PriorityQueue;

public class PriorityQueueWithArrayTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        // AddLijstFloat8001(datasetSorting);
        // Peek(datasetSorting);
        Poll(datasetSorting);
    }

    private void AddLijstFloat8001(DatasetSorting datasetSorting)
    {
        //In next loops we add three times LijstFloat8001 (without sizing array)
        //The time is increasing exponential because complexity O(N²)
        
        var sw = new ConsoleStopwatch();
        
        var priorityQueueFloat = new PriorityQueueWithArray<float>(datasetSorting.LijstFloat8001.Length * 3);
        
        //Warmup
        priorityQueueFloat.Add(-1);
        
        //Take ~220ms
        sw.Start("Adding LijstFloat8001"); 
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueueFloat.Add(item);
        }
        sw.Stop();
        
        //Take ~940ms
        sw.Start("Adding LijstFloat8001"); 
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueueFloat.Add(item);
        }
        sw.Stop();
        
        //Take ~2000ms
        sw.Start("Adding LijstFloat8001"); 
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueueFloat.Add(item);
        }
        sw.Stop();
    }
    
    private void Peek(DatasetSorting datasetSorting)
    {
        //In next loops we add three times LijstFloat8001 (without sizing array)
        //Between loops we do an Peek, the time of Peek is constant because complexity O(1)
        
        var sw = new ConsoleStopwatch();
        
        var priorityQueueFloat = new PriorityQueueWithArray<float>(datasetSorting.LijstFloat8001.Length * 3);
        
        //Warmup
        priorityQueueFloat.Peek();
        
        foreach (var item in datasetSorting.LijstFloat8001)
            priorityQueueFloat.Add(item);
        
        sw.Start("Peek 8001");
        priorityQueueFloat.Peek();
        sw.Stop();
        
        foreach (var item in datasetSorting.LijstFloat8001)
            priorityQueueFloat.Add(item);

        sw.Start("Peek 16002");
        priorityQueueFloat.Peek();
        sw.Stop();
        
        foreach (var item in datasetSorting.LijstFloat8001)
            priorityQueueFloat.Add(item);

        sw.Start("Peek 24003");
        priorityQueueFloat.Peek();
        sw.Stop();
    }
    
    private void Poll(DatasetSorting datasetSorting)
    {
        //In next loops we add three times LijstFloat8001 (without sizing array)
        //Between loops we do an Poll, the time of Peek is linear because complexity O(N)
        
        var priorityQueue = new PriorityQueueWithArray<int>(3_000_000);

        //Warmup
        priorityQueue.Poll();

        for (int i = 0; i < 1_000_000; i++)
            priorityQueue.Add(i);

        var sw = ConsoleStopwatch.Start("Poll 1_000_000");
        priorityQueue.Poll();
        sw.Stop();
        
        for (int i = 1_000_000; i < 2_000_000; i++)
            priorityQueue.Add(i); 
        
        sw.Start("Poll 2_000_000");
        priorityQueue.Poll();
        sw.Stop();
        
        for (int i = 2_000_000; i < 3_000_000; i++)
            priorityQueue.Add(i); 
        
        sw.Start("Poll 3_000_000");
        priorityQueue.Poll();
        sw.Stop();
    }
}