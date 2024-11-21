namespace ADP.Operations.DoublyLinkedLists;

public class DoubleLinkedListNode<T>
{
    public DoubleLinkedListNode(T data)
    {
        Data = data;
    }
    
    public DoubleLinkedListNode<T> Prev { get; set; }
    public DoubleLinkedListNode<T> Next { get; set; }

    public T Data { get; set; }
}