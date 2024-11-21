namespace ADP.Operations.SinglyLinkedList;

public class SinglyLinkedList <T> where T : IComparable<T>
{
    public SinglyLinkedListHeadNode<T> HeadNode { get; set; } = new();
}