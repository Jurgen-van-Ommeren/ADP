using System.Diagnostics;
using ADP.Dataset;
using ADP.Testing;

namespace ADP.Sorting.MergeSort;

public class MergeSortTests
{
    public void Run(DatasetSorting datasetSorting)
    {
       
        var sw = new Stopwatch();
        long avarage = 0;
        
        for (int i = 0; i < 1000; i++)
        {
            var array2 = datasetSorting.LijstFloat8001.ToArray();
            
            sw.Start();
            MergeSort<float>.Sort(array2);
            sw.Stop();
            
            avarage += sw.ElapsedTicks;
            sw.Reset();
        }
        Console.WriteLine($"Average elapsed ticks: {avarage / 1000} ticks");
        
        avarage = 0;
        
        var longerArray = datasetSorting.LijstFloat8001
            .Concat(datasetSorting.LijstFloat8001)
            .Concat(datasetSorting.LijstFloat8001)
            .Concat(datasetSorting.LijstFloat8001)
            .Concat(datasetSorting.LijstFloat8001)
            .Concat(datasetSorting.LijstFloat8001)
            .Concat(datasetSorting.LijstFloat8001)
            .Concat(datasetSorting.LijstFloat8001)
            .Concat(datasetSorting.LijstFloat8001)
            .Concat(datasetSorting.LijstFloat8001);
        
        for (int i = 0; i < 1000; i++)
        {
            var array2 = longerArray.ToArray();
            
            sw.Start();
            MergeSort<float>.Sort(array2);
            sw.Stop();
            
            avarage += sw.ElapsedTicks;
            sw.Reset();
        }
        Console.WriteLine($"Average elapsed ticks: {avarage / 1000} ticks");
    }
}