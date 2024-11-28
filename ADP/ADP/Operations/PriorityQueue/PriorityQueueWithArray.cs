using ADP.Testing;

namespace ADP.Operations.PriorityQueue;

public class PriorityQueueWithArray<T> where T : IComparable
{
    private T[] _items = new T[0];
    private int _size = 0;

    public PriorityQueueWithArray()
    {
        
    }
    
    public PriorityQueueWithArray(int capacity)
    {
        _items = new T[capacity];
    }
    
    public void Add(T value)
    {
        EnsureSize();
        
        var nodeIndex = _size;
        
        while (nodeIndex > 0)
        {
            var parentIndex = nodeIndex - 1;
            var parent = _items[parentIndex];

            if (value.CompareTo(parent) < 0)
            {
                _items[nodeIndex] = parent;
                nodeIndex = parentIndex;
            }
            else
            {
                break;
            }
        }
        
        _items[nodeIndex] = value;

        _size++;
    }
    
    public T Peek()
    {
        if (_size == 0)
        {
            return default;
        }
        
        return _items[0];
    }
    
    public T Poll()
    {
        var sw = new ConsoleStopwatch();
        sw.Start($"Poll inside {_size}");
        
        if (_size == 0)
        {
            sw.Stop();
            
            return default;
        }

        var value = _items[0];
        
        for (var i = 1; i < _size; i++)
        {
            _items[i - 1] = _items[i];    
        }
        
        _size--;
        
        sw.Stop();

        return value;
    }

    private void EnsureSize()
    {
        if (_size == _items.Length)
        {
            var newItems = new T[_items.Length * 2 + 1];

            for (var i = 0; i < _size; i++)
            {
                newItems[i] = _items[i];
            }

            _items = newItems;
        }
    }
}