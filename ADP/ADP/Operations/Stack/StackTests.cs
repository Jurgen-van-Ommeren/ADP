using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.Stack;

public class StackTests
{
    public void Run(DatasetSorting datasetSorting)
    {
        var stack = new Stack<float>();
        
        //takes 27777 ticks
        ConsoleStopwatch.Start("pushing LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            stack.Push(item);
        }
        ConsoleStopwatch.Stop();
        
        //takes 10187 ticks
        // complexity = 1: because there are no loops, the time it takes to take the first item out of the list doesn't change when the list is longer.
        ConsoleStopwatch.Start("popping LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            stack.Pop();
        }
        ConsoleStopwatch.Stop();

    }
    
   
}