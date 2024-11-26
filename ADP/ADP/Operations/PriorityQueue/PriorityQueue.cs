using ADP.Operations.SinglyLinkedList;

namespace ADP.Operations.PriorityQueue;

public class PriorityQueue<T> where T : IComparable<T>
{
    private SinglyLinkedList<T> _stack;

    public PriorityQueue()
    {
        _stack = new SinglyLinkedList<T>();
    }

    public void Add(T node)
    {
        var newNode = new SinglyLinkedListNode<T>()
        {
            Node = node,
            Next = _stack.HeadNode.Next
        };

        if (_stack.HeadNode.Next == null)
        {
            _stack.HeadNode.Next = newNode;
        }
        else
        {
            PlaceAtRightPriority(node);
        }
    }

    public T Peek()
    {
        if (_stack.HeadNode.Next == null)
            return default;

        return _stack.HeadNode.Next.Node;
    }

    public T Poll()
    {
        if (_stack.HeadNode.Next == null)
            return default;

        T node = _stack.HeadNode.Next.Node;

        _stack.HeadNode.Next = _stack.HeadNode.Next.Next;

        return node;
    }

    private void PlaceAtRightPriority(T node)
    {
        var newNode = new SinglyLinkedListNode<T>()
        {
            Node = node,
            Next = null
        };

        var compareNode = _stack.HeadNode.Next;

        if (compareNode == null)
        {
            _stack.HeadNode.Next = newNode;
        }
        else
        {
            CompareNodes(newNode, compareNode);
        }
    }

    private void CompareNodes(SinglyLinkedListNode<T> node, SinglyLinkedListNode<T> compareNode, SinglyLinkedListNode<T> previousNode = null)
    {
        if (compareNode == null && previousNode != null)
        {
            previousNode.Next = node;
            
            return;
        }
        
        if (node.Node.CompareTo(compareNode.Node) <= 0)
        {
            node.Next = compareNode;
            
            if (previousNode != null)
                previousNode.Next = node;
            
        }
        else
        {
            CompareNodes(node, compareNode.Next, compareNode);
        }
    }
}