namespace ADP.Sorting.BinarySearch;

public class BinarySearch<T>
    where T : IComparable<T>
{
    public static int Search(T[] array, T item)
    {
        if (array == null || array.Length == 0)
        {
            return -1;
        }

        var startIndex = 0;
        var endIndex = array.Length - 1;

        var compareStartIndex = item.CompareTo(array[startIndex]);
        var compareEndIndex = item.CompareTo(array[endIndex]);

        if (compareStartIndex == -1 || compareEndIndex == 1)
        {
            return -1;
        }

        if (compareStartIndex == 0)
        {
            return startIndex;
        }

        if (compareEndIndex == 0)
        {
            return endIndex;
        }

        var index = CompareIndexes(array, item, startIndex, endIndex);
        return index;
    }

    private static int CompareIndexes(T[] array, T item, int startIndex, int endIndex)
    {
        if (startIndex > endIndex)
            return -1;

        var medianIndex = startIndex + (endIndex - startIndex) / 2;

        var comparison = item.CompareTo(array[medianIndex]);

        switch (comparison)
        {
            case 0:
                return medianIndex;
            case -1:
                return CompareIndexes(array, item, startIndex, medianIndex - 1);
            default:
                return CompareIndexes(array, item, medianIndex + 1, endIndex);
        }
    }
}