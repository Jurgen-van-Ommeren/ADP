using ADP.Operations.SinglyLinkedList;

namespace ADP.Operations.Stack;

public class Stack<T> where T : IComparable<T>
{
    private SinglyLinkedList<T> _stack;

    public Stack()
    {
        _stack = new SinglyLinkedList<T>();
    }

    public void Push(T node)
    {
        var newNode = new SinglyLinkedListNode<T>()
        {
            Node = node,
            Next = _stack.HeadNode.Next
        };

        _stack.HeadNode.Next = newNode;

    }

    public T Pop()
    {
        if (_stack.HeadNode.Next == null)
            throw new IndexOutOfRangeException();

        var node = _stack.HeadNode.Next.Node;

        _stack.HeadNode.Next = _stack.HeadNode.Next.Next;
        
        return node;
    }

    public T Peek()
    {
        if (_stack.HeadNode.Next == null)
            throw new IndexOutOfRangeException();

        return _stack.HeadNode.Next.Node;
    }

    public bool IsEmpty()
    {
        return _stack.HeadNode.Next == null;
    }
}