using ADP.Operations.SinglyLinkedList;

namespace ADP.Operations.Stack;

public class Stack<T> where T : IComparable<T>
{
    private SinglyLinkedList<T> _stack;

    public Stack()
    {
        _stack = new SinglyLinkedList<T>();
    }

    public void Push(T data)
    {
        var newNode = new SinglyLinkedListNode<T>()
        {
            Data = data,
            Next = _stack.HeadNode.Next
        };

        _stack.HeadNode.Next = newNode;
    }

    public T Pop()
    {
        if (_stack.HeadNode.Next == null)
            throw new IndexOutOfRangeException();

        var data = _stack.HeadNode.Next.Data;

        _stack.HeadNode.Next = _stack.HeadNode.Next.Next;
        
        return data;
    }

    public T Peek()
    {
        if (_stack.HeadNode.Next == null)
            throw new IndexOutOfRangeException();

        return _stack.HeadNode.Next.Data;
    }

    public bool IsEmpty()
    {
        return _stack.HeadNode.Next == null;
    }
}