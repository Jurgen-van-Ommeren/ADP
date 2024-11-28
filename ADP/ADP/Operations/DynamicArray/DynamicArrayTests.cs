using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.DynamicArray;

public class DynamicArrayTests
{
    public void Run(DatasetSorting datasetSorting)
    {
        var array = new DynamicArray<float>(8002);
        
        //complexity:
        //takes 12883 ticks
        ConsoleStopwatch.Start("adding LijstFloat8001");
        
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        //complexity: 1, because the index directly references to the place where the data is stored.
        //takes 3636 ticks
        ConsoleStopwatch.Start("getting LijstFloat8001");
        for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        {
            array.Get(i);
        }
        ConsoleStopwatch.Stop();
        
        //complexity: 1, because the index directly references to the place where the data will be stored.
        //takes 2761 ticks
        ConsoleStopwatch.Start("setting LijstFloat8001");
        for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        {
            array.Set(i, datasetSorting.LijstFloat8001[i]);
        }
        ConsoleStopwatch.Stop();
        
        //complexity: O N, because there is 1 loop, the iterations it takes to find the item grows linear with the amount of items.
        // takes 16986 ticks
        ConsoleStopwatch.Start("contains LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Contains(item);
        }
        ConsoleStopwatch.Stop();
        
        //complexity: O N, because there is 1 loop, the iterations it takes to find the item grows linear with the amount of items.
        // takes 17029 ticks
        ConsoleStopwatch.Start("index of LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.IndexOf(item);
        }
        ConsoleStopwatch.Stop();
        
        //complexity: O N^2, because there is 1 loop for comparing the items and 1 loop for swiping the array
        // takes 4198643 ticks
        ConsoleStopwatch.Start("remove item from LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Remove(item);
        }
        ConsoleStopwatch.Stop();

        //complexity: O N, because there is 1 loop for swiping the array
        //takes 1319261 ticks
        ConsoleStopwatch.Start("removing by index LijstFloat8001");
        for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        {
            array.Remove(i);
        }
        ConsoleStopwatch.Stop();
        

    }
}