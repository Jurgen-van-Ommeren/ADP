namespace ADP.Operations.HashTable;

public class HashTable<T>
{
    private readonly HashTableChain<T>[] _table;

    public HashTable(int capacity)
    {
        _table = new HashTableChain<T>[capacity];
    }

    public void Insert(string key, T value) //Todo overwrite if exists?
    {
        var index = GetIndex(key);

        var chain = _table[index];
        if (chain == null)
        {
            chain = new HashTableChain<T>();
            _table[index] = chain;
        }

        if (chain.Next == null)
        {
            chain.Next = new HashTableChainNode<T>()
            {
                Key = key,
                Data = value
            };

            return;
        }
            
        var lastNode = chain.Next;

        while (lastNode.Next != null)
        {
            lastNode = lastNode.Next;
        }
        
        lastNode.Next = new HashTableChainNode<T>()
        {
            Key = key,
            Data = value
        };
    }

    public T Get(string key)
    {
        var index = GetIndex(key);
        
        var chain = _table[index];
        if (chain == null)
            return default;

        var currentNode = chain.Next;
        
        while (currentNode != null)
        {
            if (currentNode.Key.Equals(key))
            {
                return currentNode.Data;
            }

            currentNode = currentNode.Next;
        }
        
        return default;
    }

    public void Delete(string key)
    {
        var index = GetIndex(key);
    }

    public void Update(string key, T value)
    {
        var index = GetIndex(key);
    }

    private int GetIndex(string key)
    {
        var total = 0;
        
        foreach (var character in key)
        {
            total += character;
        }
        
        return total % _table.Length;
    }
}