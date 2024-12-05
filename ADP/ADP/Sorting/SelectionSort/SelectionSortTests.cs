using ADP.Dataset;
using ADP.Testing;

namespace ADP.Sorting.SelectionSort;

public class SelectionSortTests
{
    public void RunTests(DatasetSorting datasetSorting)
    {
        ConsoleStopwatch.Start("SelectionSort Unsorted LijstWillekeurig10000");
        
        SelectionSort<int>.Sort(datasetSorting.LijstWillekeurig10000);
        
        ConsoleStopwatch.Stop();
        
        var aflopend = datasetSorting.LijstOplopend10000.Reverse().ToArray();
        var oplopend = datasetSorting.LijstOplopend10000;
        
        ConsoleStopwatch.Start("SelectionSort aflopend LijstOplopend10000 reversed");
        
        SelectionSort<int>.Sort(aflopend);
        
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("SelectionSort oplopend LijstOplopend10000");
        
        SelectionSort<int>.Sort(oplopend);
        
        ConsoleStopwatch.Stop();
        
        //amount of loops = 49994999
        //complexity = n * 1/2 N so n^2
    }
}