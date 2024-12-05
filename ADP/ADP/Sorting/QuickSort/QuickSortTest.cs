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
        
        ConsoleStopwatch.Start("Quick sorting LijstWillekeurig10000"); 
        quickSort.Sort(datasetSorting.LijstWillekeurig10000);
        ConsoleStopwatch.Stop();
        
        var lijstAflopend10000 = datasetSorting.LijstOplopend10000
            .Reverse()
            .ToArray();
        
        //Todo
        ConsoleStopwatch.Start("Insertion sorting lijstAflopend10000"); 
        quickSort.Sort(lijstAflopend10000);
        ConsoleStopwatch.Stop();
        
        var lijstAflopend100000 = lijstAflopend10000;
        for (int i = 0; i < 10; i++)
            lijstAflopend100000 = lijstAflopend100000.Concat(lijstAflopend10000).ToArray();
        
        //Todo
        ConsoleStopwatch.Start("Insertion sorting lijstAflopend100000"); 
        quickSort.Sort(lijstAflopend100000);
        ConsoleStopwatch.Stop();

        //Todo
        ConsoleStopwatch.Start("Insertion sorting sorted lijstAflopend10000"); 
        quickSort.Sort(lijstAflopend10000);
        ConsoleStopwatch.Stop();
        
        var lijstZelfdeGetallen = new int[10_000];
        for (var i = 0; i < lijstZelfdeGetallen.Length; i++)
            lijstZelfdeGetallen[i] = 5;
        
        //Todo 
        ConsoleStopwatch.Start("Insertion sorting sorted lijstZelfdeGetallen"); 
        quickSort.Sort(lijstZelfdeGetallen);
        ConsoleStopwatch.Stop();
    }
}