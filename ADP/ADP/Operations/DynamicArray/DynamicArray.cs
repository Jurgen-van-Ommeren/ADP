using System.Collections;

namespace ADP.Operations.DynamicArray;

public class DynamicArray<T> where T : IComparable<T>
{
    private const int DefaultCapacity = 4;

    private T[] _items;

    private int _size;

    private static readonly T[] EmptyArray = new T[0];

    public DynamicArray()
    {
        _items = EmptyArray;
    }

    public DynamicArray(int length)
    {
        if (length == 0)
        {
            _items = EmptyArray;
        }
        else if (length > 0)
        {
            _items = new T[length];
        }
    }

    public void Add(T item)
    {
        if (_size < _items.Length)
        {
            _items[_size] = item;
            _size += 1;
        }
        else
        {
            ResizeAndAdd(item);
        }
    }

    public T Get(int index)
    {
        if (_size > index)
        {
            return _items[index];
        }

        throw new IndexOutOfRangeException();
    }

    public void Set(int index, T item)
    {
        if (_size < index)
        {
            throw new IndexOutOfRangeException();
        }

        _items[index] = item;
    }

    public void Remove(int index)
    {
        if (_size <= index)
            throw new IndexOutOfRangeException();

        _size -= 1;

        if (_size == index)
        {
            _items[_size] = default;
        }
        else
        {
            RemoveItemFromArray(index);
        }
    }

    public void Remove(T item)
    {
        for (var i = 0; i < _size; i++)
        {
            if (item.CompareTo(_items[i]) == 0)
            {
                RemoveItemFromArray(i);
                _size--;
                return;
            }
        }
        
        throw new IndexOutOfRangeException();
    }

    public bool Contains(T item)
    {
        for (var i = 0; i < _size; i++)
        {
            if (item.CompareTo(_items[i]) == 0)
            {
                return true;
            }
        }

        return false;
    }

    public int IndexOf(T item)
    {
        for (var i = 0; i < _size; i++)
        {
            if (item.CompareTo(_items[i]) == 0)
            {
                return i;
            }
        }

        throw new IndexOutOfRangeException();
    }

    private void ResizeAndAdd(T item)
    {
        GrowArray(_size + 1);

        _items[_size] = item;
        _size++;
    }

    private void GrowArray(int newSize)
    {
        var newCapacity = _items.Length == 0 ? DefaultCapacity : 2 * _items.Length;
        var newItems = new T[newCapacity];

        if (_size > 0)
        {
            for (var i = 0; i < _size; i++)
            {
                newItems[i] = _items[i];
            }
        }

        _items = newItems;
    }

    private void RemoveItemFromArray(int index)
    {
        for (var i = index; i < _size; i++)
        {
            _items[i] = _items[i + 1];
        }
    }
}