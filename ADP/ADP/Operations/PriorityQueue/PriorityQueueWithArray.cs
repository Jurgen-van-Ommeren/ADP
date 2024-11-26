namespace ADP.Operations.PriorityQueue;

public class PriorityQueueWithArray<T> where T : IComparable
{
    private T[] _items = new T[0];
    private int _size = 0;

    public void Add(T value)
    {
        var originalItems = _items;
        
        if (_size == _items.Length)
        {
            _items = new T[_items.Length * 2 + 1];
        }

        var nodeIndex = _size;
        
        while (nodeIndex > 0)
        {
            var parentIndex = nodeIndex - 1;
            var parent = originalItems[parentIndex];

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
    
    public void Poll()
    {
        if (_size == 0)
        {
            return;
        }

        for (var i = 1; i < _size; i++)
        {
            _items[i - 1] = _items[i];    
        }
        
        _size--;
    }
}