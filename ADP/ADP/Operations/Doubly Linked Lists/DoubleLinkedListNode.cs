namespace ADP.ADT_Operations.Doubly_Linked_Lists;

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