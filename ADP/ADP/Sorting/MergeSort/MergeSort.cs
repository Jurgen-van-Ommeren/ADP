namespace ADP.Sorting.MergeSort;

public class MergeSort<T> where T : IComparable<T> 
{
    public static void Sort(T[] array)
    {
        var temp = new T[array.Length];
        SortArray(array, temp, 0, array.Length - 1);
    }

    private static void SortArray(T[] array, T[] temp, int left, int right)
    {
        if (left >= right) 
            return;
        
        var middle = (left + right) / 2;
        SortArray(array, temp, left, middle);
        SortArray(array, temp, middle + 1, right);
        Merge(array, temp, left, middle + 1 , right);
    }

    private static void Merge(T[] array, T[] temp, int left,int middle, int right)
    {
        for (int i = left; i <= right; i++)
        {
            temp[i] = array[i];
        }
        
        var leftIndex = left;
        var rightIndex = middle;
        var currentIndex = left;

        while (leftIndex <= middle - 1 && rightIndex <= right)
        {
            if (Comparer<T>.Default.Compare(temp[leftIndex], temp[rightIndex]) <= 0)
            {
                array[currentIndex] = temp[leftIndex];
                leftIndex++;
            }
            else
            {
                array[currentIndex] = temp[rightIndex];
                rightIndex++;
            }
            currentIndex++;
        }

        while (leftIndex <= middle - 1)
        {
            array[currentIndex] = temp[leftIndex];
            leftIndex++;
            currentIndex++;
        }

        while (rightIndex <= right)
        {
            array[currentIndex] = temp[rightIndex];
            rightIndex++;
            currentIndex++;
        }
    }
}