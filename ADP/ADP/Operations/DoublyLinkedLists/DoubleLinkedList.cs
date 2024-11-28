namespace ADP.Operations.DoublyLinkedLists;

public class DoubleLinkedList<T>
    where T : IComparable<T>
{
    private DoubleLinkedListNode<T> _firstNode;
    private DoubleLinkedListNode<T> _lastNode;
    
    private int _size;

    public void Add(T value)
    {
        var newNode = new DoubleLinkedListNode<T>(value);

        if (_firstNode == null)
        {
            _firstNode = newNode;
            _lastNode = newNode;
        }
        else
        {
            newNode.Prev = _lastNode;

            _lastNode.Next = newNode;
            _lastNode = newNode;
        }

        _size++;
    }

    public T Get(int index)
    {
        if (_size <= index)
        {
            throw new IndexOutOfRangeException();
        }

        var node = GetNode(index);

        return node.Data;
    }

    public void Set(int index, T value)
    {
        if (index > _size)
        {
            throw new IndexOutOfRangeException();
        }

        var currentNode = GetNode(index);
        currentNode.Data = value;
    }

    public void Remove(int index)
    {
        if (_size <= index)
        {
            throw new IndexOutOfRangeException();
        }

        var node = GetNode(index);
        
        RemoveNode(node);
    }

    public void Remove(T value)
    {
        var node = GetNode(value);
        if (node == null)
        {
            return;
        }
        
        RemoveNode(node);
    }

    public bool Contains(T value)
    {
        return GetNode(value) != null;
    }

    public int IndexOf(T value)
    {
        var currentNode = _firstNode;
        var currentIndex = 0;

        while (currentNode != null)
        {
            if (currentNode.Data.CompareTo(value) != 0)
            {
                currentNode = currentNode.Next;
                currentIndex++;
            }
            else
            {
                return currentIndex;
            }
        }

        return -1;
    }

    private DoubleLinkedListNode<T> GetNode(int index)
    {
        if (index > _size / 2)
        {
            var currentIndex = _size - 1;
            var currentNode = _lastNode;

            while (currentNode != null)
            {
                if (currentIndex != index)
                {
                    currentNode = currentNode.Prev;
                    currentIndex--;
                }
                else
                {
                    return currentNode;
                }
            }
        }
        else
        {
            var currentIndex = 0;
            var currentNode = _firstNode;

            while (currentNode != null)
            {
                if (currentIndex != index)
                {
                    currentNode = currentNode.Next;
                    currentIndex++;
                }
                else
                {
                    return currentNode;
                }
            }
        }

        return null;
    }

    private DoubleLinkedListNode<T> GetNode(T data)
    {
        var currentNode = _firstNode;

        while (currentNode != null)
        {
            if (currentNode.Data.CompareTo(data) != 0)
            {
                currentNode = currentNode.Next;
            }
            else
            {
                return currentNode;
            }
        }

        return null;
    }

    private void RemoveNode(DoubleLinkedListNode<T> node)
    {
        if (node.Prev != null)
        {
            node.Prev.Next = node.Next;
        }
        else
        {
            _firstNode = node.Next;
        }

        if (node.Next != null)
        {
            node.Next.Prev = node.Prev;
        }
        else
        {
            _lastNode = node.Prev;
        }

        _size--;
    }
}