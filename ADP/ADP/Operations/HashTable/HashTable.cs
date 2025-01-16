namespace ADP.Operations.HashTable;

//Todo: Be ready to explain the differences between your implementation and other ones we covered during the lesson.
//Todo: Use prime number?

//Middels Separate Chaining
//Geen Linear Probing
//Geen Quadratic Probing
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
        
        var chain = _table[index];
        if (chain == null)
            return;

        if (chain.Next.Key.Equals(key))
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
        var index = GetIndex(key); 
        
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
    
    private int GetIndex(string key)
    {
        var total = 0;
        
        foreach (var character in key)
        {
            total += character;
        }
        
        return total % _table.Length;
    }
 
    private static readonly int[] Primes = { 3, 7, 11, 17, 23, 29, 37, 47, 59, 71, 89, 107, 131, 163, 197, 239, 293, 353, 431, 521, 631, 761, 919, 1103, 1327, 1597, 1931, 2333, 2801, 3371, 4049, 4861, 5839, 7013, 8419, 10103, 12143, 14591, 17519, 21023, 25229, 30293, 36353, 43627, 52361, 62851, 75431, 90523, 108631, 130363, 156437, 187751, 225307, 270371, 324449, 389357, 467237, 560689, 672827, 807403, 968897, 1162687, 1395263, 1674319, 2009191, 2411033, 2893249, 3471899, 4166287, 4999559, 5999471, 7199369 };
    
    private int GetPrime(int min)
    {
        foreach (var prime in Primes)
        {
            if (prime >= min)
            {
                return prime;
            }
        }

        throw new ArgumentOutOfRangeException();
    }

    private void Resize()
    {
        
    }
}