namespace ADP.Operations.Deque;

public class DequeNode<T>
{
    public DequeNode(T data)
    {
        Data = data;
    }
    
    public DequeNode<T> Prev { get; set; }
    public DequeNode<T> Next { get; set; }

    public T Data { get; set; }
}