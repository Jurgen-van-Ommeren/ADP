namespace ADP.Operations.HashTable;

public class HashTableChainNode<T>
{
    public string Key { get; set; }
    public T Data { get; set; }
    public HashTableChainNode<T> Next { get; set; }
}