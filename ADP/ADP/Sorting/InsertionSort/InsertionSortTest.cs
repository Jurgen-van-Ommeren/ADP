using ADP.Dataset;
using ADP.Testing;

namespace ADP.Sorting.InsertionSort;

public class InsertionSortTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        var insertionSort = new InsertionSort<int>();
        
        //Warmup
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        insertionSort.Sort(new[] {1});
        
        //Took 204683 ticks, complexity is O(N²).
        ConsoleStopwatch.Start("Insertion sorting LijstWillekeurig10000"); 
        insertionSort.Sort(datasetSorting.LijstWillekeurig10000);
        ConsoleStopwatch.Stop();

        var lijstAflopend10000 = datasetSorting.LijstOplopend10000
            .Reverse()
            .ToArray();
        
        //Took 1913067 ticks, complexity is O(N²).
        ConsoleStopwatch.Start("Insertion sorting lijstAflopend10000"); 
        insertionSort.Sort(lijstAflopend10000);
        ConsoleStopwatch.Stop();
        
        var lijstAflopend100000 = lijstAflopend10000;
        for (int i = 0; i < 10; i++)
            lijstAflopend100000 = lijstAflopend100000.Concat(lijstAflopend10000).ToArray();
        
        //Took 126117743 ticks, more than 10x more, because complexity is O(N²).
        ConsoleStopwatch.Start("Insertion sorting lijstAflopend100000"); 
        insertionSort.Sort(lijstAflopend100000);
        ConsoleStopwatch.Stop();

        //Took 575 ticks, is shorter because compexity is O(n). 
        ConsoleStopwatch.Start("Insertion sorting sorted lijstAflopend10000"); 
        insertionSort.Sort(lijstAflopend10000);
        ConsoleStopwatch.Stop();
        
        var lijstZelfdeGetallen = new int[10_000];
        for (var i = 0; i < lijstZelfdeGetallen.Length; i++)
            lijstZelfdeGetallen[i] = 5;
        
        //Took 570 ticks, is shorter because compexity is O(n). 
        ConsoleStopwatch.Start("Insertion sorting sorted lijstZelfdeGetallen"); 
        insertionSort.Sort(lijstZelfdeGetallen);
        ConsoleStopwatch.Stop();
    }
}