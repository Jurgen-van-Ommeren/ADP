using ADP.Operations.SinglyLinkedList;

namespace ADP.Operations.PriorityQueue;

public class PriorityQueue<T> where T : IComparable<T>
{
    private SinglyLinkedList<T> _head;

    public PriorityQueue()
    {
        _head = new SinglyLinkedList<T>();
    }

    public void Add(T node)
    {
        var newNode = new SinglyLinkedListNode<T>()
        {
            Data = node,
            Next = _head.HeadNode.Next
        };

        if (_head.HeadNode.Next == null)
        {
            _head.HeadNode.Next = newNode;
        }
        else
        {
            PlaceAtRightPriority(node);
        }
    }

    public T Peek()
    {
        if (_head.HeadNode.Next == null)
            throw new IndexOutOfRangeException();

        return _head.HeadNode.Next.Data;
    }

    public T Poll()
    {
        if (_head.HeadNode.Next == null)
            return default;

        T node = _head.HeadNode.Next.Data;

        _head.HeadNode.Next = _head.HeadNode.Next.Next;

        return node;
    }

    private void PlaceAtRightPriority(T node)
    {
        var newNode = new SinglyLinkedListNode<T>()
        {
            Data = node,
            Next = null
        };

        var compareNode = _head.HeadNode.Next;

        if (compareNode == null)
        {
            _head.HeadNode.Next = newNode;
        }
        else
        {
            CompareNodes(newNode, compareNode);
        }
    }

    private void CompareNodes(SinglyLinkedListNode<T> newNode, SinglyLinkedListNode<T> compareNode, SinglyLinkedListNode<T> previousNode = null)
    {
        if (compareNode == null && previousNode != null)
        {
            previousNode.Next = newNode;
            
            return;
        }
        
        if (newNode.Data.CompareTo(compareNode.Data) <= 0)
        {
            newNode.Next = compareNode;
            
            if (previousNode != null)
                previousNode.Next = newNode;
            
        }
        else
        {
            CompareNodes(newNode, compareNode.Next, compareNode);
        }
    }
}