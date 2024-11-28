using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.Stack;

public class StackTests
{
    public void Run(DatasetSorting datasetSorting)
    {
        var stack = new Stack<float>();
        
        //takes 27777 ticks
        // complexity: 1 because there are no loops, the time it takes to take the first item out of the list doesn't change when the list is longer.
        ConsoleStopwatch.Start("pushing LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            stack.Push(item);
        }
        ConsoleStopwatch.Stop();
        
        //takes 6144 ticks
        //complexity: 1 because there are no loops, the time it takes to take the first item out of the list doesn't change when the list is longer.
        ConsoleStopwatch.Start("Peeking LijstFloat8001");
        for (int i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        {
            stack.Peek();
        }
        ConsoleStopwatch.Stop();
        
        //takes 10187 ticks
        // complexity: 1 because there are no loops, the time it takes to take the first item out of the list doesn't change when the list is longer.
        ConsoleStopwatch.Start("popping LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            stack.Pop();
        }
        ConsoleStopwatch.Stop();

    }
    
   
}