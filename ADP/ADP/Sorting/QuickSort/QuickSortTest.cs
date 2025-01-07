using System.Diagnostics;
using ADP.Dataset;
using ADP.Sorting.InsertionSort;
using ADP.Testing;

namespace ADP.Sorting.QuickSort;

public class QuickSortTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        var quickSort = new QuickSort<int>();
        
        //Warmup
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        quickSort.Sort(new[] {1});

        var list = new[] { 8, 6, 0, 7, 5, 3, 1 };
        
        //Took 68.18 ticks
        var totalTicks = 0f;
        for (int i = 0; i < 100; i++)
        {
            var list2 = list
                .ToArray();
        
            var sw = new Stopwatch();
            sw.Start();
            
            quickSort.Sort(list2);
            
            sw.Stop();

            totalTicks += sw.ElapsedTicks;
        }
        Console.WriteLine($"Average quick sorting {totalTicks / 100}ms");

        //Took 33.53 ticks
        //In average shorter because O(n log n)
        totalTicks = 0f;
        for (int i = 0; i < 100; i++)
        {
            var list10 = list
                .Concat(list)
                .Concat(list)
                .Concat(list)
                .Concat(list)
                .Concat(list)
                .Concat(list)
                .Concat(list)
                .Concat(list)
                .Concat(list)
                .ToArray();
        
            var sw = new Stopwatch();
            sw.Start();
            
            quickSort.Sort(list10);
            
            sw.Stop();

            totalTicks += sw.ElapsedTicks;
        }
        Console.WriteLine($"Average quick sorting x 10 {totalTicks / 100}ms");

    
    }
}