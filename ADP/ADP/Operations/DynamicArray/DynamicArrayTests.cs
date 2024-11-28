using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.DynamicArray;

public class DynamicArrayTests
{
    public void Run(DatasetSorting datasetSorting)
    {
        var array = new DynamicArray<float>(8002);
        
        //warmup
        array.Add(1);
        
        //takes 12883 ticks
        ConsoleStopwatch.Start("adding LijstFloat8001");
        
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        
        //create new array
        array = new DynamicArray<float>(24004);
        
        //warmup
        array.Add(1);
        
        ConsoleStopwatch.Start("adding LijstFloat8001 1 times");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("adding LijstFloat8001 2 times");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("adding LijstFloat8001 3 times");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        ConsoleStopwatch.Stop();
     
        
        
        // //takes 3636 ticks
        // ConsoleStopwatch.Start("getting LijstFloat8001");
        // for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        // {
        //     array.Get(i);
        // }
        // ConsoleStopwatch.Stop();
        //
        // //takes 2761 ticks
        // ConsoleStopwatch.Start("setting LijstFloat8001");
        // for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        // {
        //     array.Set(i, datasetSorting.LijstFloat8001[i]);
        // }
        // ConsoleStopwatch.Stop();
        //
        //
        // // takes 16986 ticks
        // ConsoleStopwatch.Start("contains LijstFloat8001");
        // foreach (var item in datasetSorting.LijstFloat8001)
        // {
        //     array.Contains(item);
        // }
        // ConsoleStopwatch.Stop();
        //
        // // takes 3275
        // ConsoleStopwatch.Start("index of LijstFloat8001");
        // foreach (var item in datasetSorting.LijstFloat8001)
        // {
        //     array.IndexOf(item);
        // }
        // ConsoleStopwatch.Stop();
        //
        // // takes 2497663 ticks
        // ConsoleStopwatch.Start("remove item from LijstFloat8001");
        // foreach (var item in datasetSorting.LijstFloat8001)
        // {
        //     array.Remove(item);
        // }
        // ConsoleStopwatch.Stop();
        //
        // foreach (var item in datasetSorting.LijstFloat8001)
        // {
        //     array.Add(item);
        // }
        //
        // //takes 3423737
        // ConsoleStopwatch.Start("removing by index LijstFloat8001");
        // for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        // {
        //     array.Remove(i);
        // }
        // ConsoleStopwatch.Stop();
        //
        //
    }
}