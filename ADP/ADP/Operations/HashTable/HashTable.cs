namespace ADP.Operations.HashTable;


public class HashTable<T>
{
    private HashTableChain<T>[] _table = Array.Empty<HashTableChain<T>>();
    private int _size;
    private double _loadFactorThreshold = 0.75;

    public HashTable()
    {
        
    }
    
    public HashTable(int capacity)
    {
        _table = new HashTableChain<T>[capacity];
    }

    public void Insert(string key, T value)
    {
        var existing = Get(key);
        if (existing != null)
        {
            throw new Exception();
        }

        EnsureSize();
        
        InsertInternal(
            _table,
            new HashTableChainNode<T>()
            {
                Key = key,
                Data = value
            }
        );

        _size++;
    }

    private void InsertInternal(HashTableChain<T>[] table, HashTableChainNode<T> node)
    {
        var index = GetIndex(node.Key, table.Length);

        var chain = table[index];
        if (chain == null)
        {
            chain = new HashTableChain<T>();
            table[index] = chain;
        }
        
        if (chain.Next == null)
        {
            chain.Next = node;
            return;
        }
            
        var lastNode = chain.Next;

        while (lastNode.Next != null)
        {
            lastNode = lastNode.Next;
        }

        lastNode.Next = node;
    }

    public T Get(string key)
    {
        if (_size == 0)
        {
            return default;
        }
        
        var index = GetIndex(key, _table.Length);
        
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
        if (_size == 0)
        {
            return;
        }
        
        var index = GetIndex(key, _table.Length);
        
        var chain = _table[index];
        if (chain == null)
            return;

        if (
            chain.Next.Next == null &&
            chain.Next.Key.Equals(key) 
            ) 
        {
            _table[index] = null;
            return;
        }
        
        var previousNode = chain.Next;
        
        while (previousNode != null)
        {
            if (previousNode.Next.Key.Equals(key))
            {
                previousNode.Next = previousNode.Next.Next;
                return;
            }

            previousNode = previousNode.Next;
        }
    }

    public void Update(string key, T value)
    {
        if (_size == 0)
        {
            return;
        }
        
        var index = GetIndex(key, _table.Length); 
        
        var chain = _table[index];
        if (chain == null)
            return;
        
        var currentNode = chain.Next;
        
        while (currentNode != null)
        {
            if (currentNode.Key.Equals(key))
            {
                currentNode.Data = value;
                return;
            }

            currentNode = currentNode.Next;
        }
    }
    
    private int GetIndex(string key, int tableSize)
    {
        var total = 0;
        
        foreach (var character in key)
        {
            total += character;
        }
        
        return total % tableSize;
    }
 
    private void EnsureSize()
    {
        if (_size < _loadFactorThreshold * _table.Length)
        {
            return;
        }
        
        var newTable = new HashTableChain<T>[_table.Length * 2 + 1];
        
        for (var i = 0; i < _table.Length; i++)
        {
            var chain = _table[i];
            if (chain == null)
            {
                continue;
            }
            
            var currentNode = chain.Next;
            while (currentNode != null)
            {
                var insertingNode = currentNode;
                
                InsertInternal(
                    newTable,
                    insertingNode
                );
                
                currentNode = currentNode.Next;
                
                insertingNode.Next = null;
            }
        }

        _table = newTable;
    }
}