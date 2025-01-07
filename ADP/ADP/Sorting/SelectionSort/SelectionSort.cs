namespace ADP.Sorting.SelectionSort;

public class SelectionSort<T>
    where T : IComparable<T>
{
    public static void Sort(T[] array)
    {
        var arrayLength = array.Length;

        for (var indexToValidate = 0; indexToValidate < arrayLength - 1; indexToValidate++)
        {
            var minIndex = indexToValidate;

            for (var indexToValidateAgainst = indexToValidate + 1; indexToValidateAgainst < arrayLength; indexToValidateAgainst++)
            {
                if (array[indexToValidateAgainst].CompareTo(array[minIndex]) < 0)
                {
                    minIndex = indexToValidateAgainst;
                }
            }
            
            (array[minIndex], array[indexToValidate]) = (array[indexToValidate], array[minIndex]);
        }
    }
}