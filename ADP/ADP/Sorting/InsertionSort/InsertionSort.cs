namespace ADP.Sorting.InsertionSort;

public class InsertionSort<T> where T : IComparable<T> 
{
    public void Sort(T[] collection)
    {
        for (var i = 1; i < collection.Length; i++) {
            var toBeInserted = collection[i];
            
            var j = i;
            while (j > 0 && toBeInserted.CompareTo(collection[j - 1]) < 0) {
                collection[j] = collection[j - 1];
                j--;
            }
            
            collection[j] = toBeInserted;
        }
    }
}