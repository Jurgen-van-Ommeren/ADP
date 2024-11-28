using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.DynamicArray;

public class DynamicArrayTests
{
    public void Run(DatasetSorting datasetSorting)
    {
        var sw = new ConsoleStopwatch();

        var array = new DynamicArray<float>(8002);
        
        //warmup
        array.Add(1);
        
        //takes 12883 ticks
        sw.Start("adding LijstFloat8001");
        
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        sw.Stop();
        
        
        //create new array
        array = new DynamicArray<float>(24004);
        
        //warmup
        array.Add(1);
        
        sw.Start("adding LijstFloat8001 1 times");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        sw.Stop();
        
        sw.Start("adding LijstFloat8001 2 times");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        sw.Stop();
        
        sw.Start("adding LijstFloat8001 3 times");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        sw.Stop();
     
        
        
        // //takes 3636 ticks
        // sw.Start("getting LijstFloat8001");
        // for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        // {
        //     array.Get(i);
        // }
        // sw.Stop();
        //
        // //takes 2761 ticks
        // sw.Start("setting LijstFloat8001");
        // for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        // {
        //     array.Set(i, datasetSorting.LijstFloat8001[i]);
        // }
        // sw.Stop();
        //
        //
        // // takes 16986 ticks
        // sw.Start("contains LijstFloat8001");
        // foreach (var item in datasetSorting.LijstFloat8001)
        // {
        //     array.Contains(item);
        // }
        // sw.Stop();
        //
        // // takes 3275
        // sw.Start("index of LijstFloat8001");
        // foreach (var item in datasetSorting.LijstFloat8001)
        // {
        //     array.IndexOf(item);
        // }
        // sw.Stop();
        //
        // // takes 2497663 ticks
        // sw.Start("remove item from LijstFloat8001");
        // foreach (var item in datasetSorting.LijstFloat8001)
        // {
        //     array.Remove(item);
        // }
        // sw.Stop();
        //
        // foreach (var item in datasetSorting.LijstFloat8001)
        // {
        //     array.Add(item);
        // }
        //
        // //takes 3423737
        // sw.Start("removing by index LijstFloat8001");
        // for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        // {
        //     array.Remove(i);
        // }
        // sw.Stop();
        //
        //
    }
}