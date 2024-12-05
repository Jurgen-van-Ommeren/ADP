namespace ADP.Sorting.QuickSort;

public class QuickSort<T> where T : IComparable<T> 
{
    public void Sort(T[] collection)
    {
        Sort(collection, 0, collection.Length - 1);        
    }

    private void Sort(T[] collection, int low, int high)
    {
        if (low >= high)
        {
            return;
        }

        var pivotIndex = Partition(collection, low, high);
        
        Sort(collection, low, pivotIndex - 1);
        Sort(collection, pivotIndex + 1, high);
    }

    private int Partition(T[] collection, int low, int high)
    {
        var pivot = collection[high];
        var i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (collection[j].CompareTo(pivot) < 0)
            {
                i++;
                Swap(collection, i, j);
            }
        }

        Swap(collection, i + 1, high);
        
        return i + 1;
    } 

    private void Swap(T[] collection, int i, int j)
    {
        (collection[i], collection[j]) = (collection[j], collection[i]);
    }
}