using ADP.Dataset;
using ADP.Testing;

namespace ADP.Sorting.BinarySearch;

public class BinarySearchTests
{
    public void RunFunctionalTests()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //test all possibilities
        var index0 = BinarySearch<int>.Search(array, 1);
        var index1 = BinarySearch<int>.Search(array, 2);
        var index2 = BinarySearch<int>.Search(array, 3);
        var index3 = BinarySearch<int>.Search(array, 4);
        var index4 = BinarySearch<int>.Search(array, 5);
        var index5 = BinarySearch<int>.Search(array, 6);
        var index6 = BinarySearch<int>.Search(array, 7);
        var index7 = BinarySearch<int>.Search(array, 8);
        var index8 = BinarySearch<int>.Search(array, 9);
        var index9 = BinarySearch<int>.Search(array, 10);
        
        //test false inputs
        var emptyArray = BinarySearch<int>.Search(Array.Empty<int>(), 2);
        var notExistingItemArray = BinarySearch<int>.Search(array, 20);
    }

    public void Run(DatasetSorting datasetSorting)
    {
        ConsoleStopwatch.Start("item op index 2 LijstOplopend10000");
        BinarySearch<int>.Search(datasetSorting.LijstOplopend10000, datasetSorting.LijstOplopend10000[2]);
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("item op index 5 LijstWillekeurig10000");
        BinarySearch<int>.Search(datasetSorting.LijstWillekeurig10000, datasetSorting.LijstWillekeurig10000[2]);
        ConsoleStopwatch.Stop();
    }
}