using System.Collections;

namespace ADP.Operations.DynamicArray;

public class DynamicArray<T> : IEnumerable<T> where T : IComparable<T>
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

        if (_size > index)
        {
            RemoveItemFromArray(index);
        }
        else
        {
            _items[_size] = default;
        }
    }

    public void Remove(T item)
    {
        for (var i = 0; i < _size; i++)
        {
            if (item.CompareTo(_items[i]) == 0)
            {
                RemoveItemFromArray(i);
                return;
            }
        }
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
        int size = _size;
        GrowArray(size + 1);
        _size = size + 1;
        _items[size] = item;
    }

    private void GrowArray(int newSize)
    {
        var newCapacity = _items.Length == 0 ? DefaultCapacity : 2 * _items.Length;

        if (newCapacity < newSize)
            newCapacity = newSize;

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
        var newItems = new T[_items.Length];

        if (_size > 0)
        {
            for (var i = 0; i < _size; i++)
            {
                if (i == index)
                {
                    i++;
                }

                newItems[i] = _items[i];
            }
        }

        _items = newItems;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _size; i++)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}