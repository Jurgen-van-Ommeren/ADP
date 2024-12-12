using ADP.Dataset;
using ADP.Testing;
using ADP.TestObjects;

namespace ADP.Operations.PriorityQueue;

public class PriorityQueueTests
{
    public void Run(DatasetSorting datasetSorting)
    {
        var priorityQueue = new PriorityQueue<float>();
        var pizzaPriorityQueue = new PriorityQueue<Pizza>();
        
        //complexity: O N, beceuse on recalculating priority it needs to loop through the list to calculate
        //takes 1764506 ticks
        ConsoleStopwatch.Start("adding LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            priorityQueue.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("adding Pizzas");
        foreach (var item in datasetSorting.Pizzas)
        {
            pizzaPriorityQueue.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        //takes 3252 ticks
        //complexity: 1 because there are no loops, the time it takes to take the first item out of the list doesn't change when the list is longer.
        ConsoleStopwatch.Start("Peeking LijstFloat8001");
        for (int i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        {
            priorityQueue.Peek();
        }
        ConsoleStopwatch.Stop();
        
        //takes 13145 ticks
        //complexity: 1 because there are no loops, the time it takes to take the first item out of the list doesn't change when the list is longer.
        ConsoleStopwatch.Start("polling LijstFloat8001");
        for (int i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        {
            priorityQueue.Poll();
        }
        ConsoleStopwatch.Stop();
    }
}