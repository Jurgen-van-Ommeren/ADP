﻿namespace ADP.Sorting.BinarySearch;

public class BinarySearch<T>
    where T : IComparable<T>
{
    private static int _iterations;
    
    public static int Search(T[] array, T item)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine($"Iterations by empty array: {_iterations}");
            _iterations = 0;
            return -1;
        }
        
        var startIndex = 0;
        var endIndex = array.Length - 1;

        var compareStartIndex = item.CompareTo(array[startIndex]);
        var compareEndIndex = item.CompareTo(array[endIndex]);

        if (compareStartIndex == -1 || compareEndIndex == 1)
        {
            Console.WriteLine($"Iterations by not existing: {_iterations}");
            _iterations = 0;
            return -1;
        }
        
        if (compareStartIndex == 0)
        {
            Console.WriteLine($"Iterations by startIndex {startIndex}: {_iterations}");
            _iterations = 0;
            return startIndex;
        }
        
        if (compareEndIndex == 0)
        {
            Console.WriteLine($"Iterations by endIndex {endIndex}: {_iterations}");
            _iterations = 0;
            return endIndex;
        }
        
        var index =  CompareIndexes(array, item, startIndex, endIndex);
        Console.WriteLine($"Iterations by index {index}: {_iterations}");
        _iterations = 0;
        return index;
    }

    private static int CompareIndexes(T[] array, T item, int startIndex, int endIndex)
    {
        _iterations++;
        
        if (startIndex > endIndex)
            return -1;
        
        var medianIndex = startIndex + (endIndex - startIndex) / 2;

        var comparison = item.CompareTo(array[medianIndex]);
        
        switch (comparison)
        {
            case 0:
                return medianIndex;
            case -1:
                return CompareIndexes(array, item, startIndex, medianIndex -1);
            default:
                return CompareIndexes(array, item, medianIndex + 1, endIndex);
        }
    }
}