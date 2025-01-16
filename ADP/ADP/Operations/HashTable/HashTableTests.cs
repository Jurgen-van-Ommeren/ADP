using System.Text.Json;
using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.HashTable;

public class HashTableTests
{
    public void Run(DatasetHashing datasetHashing)
    {
        //Test with provided dataset.
        
        var hashTable = new HashTable<int[]>();
        
        foreach (var datasetHashingHashtabelsleutelswaarde in datasetHashing.Hashtabelsleutelswaardes)
        {
            hashTable.Insert(datasetHashingHashtabelsleutelswaarde.Key, datasetHashingHashtabelsleutelswaarde.Value);
        }
        
        Console.WriteLine(JsonSerializer.Serialize(hashTable.Get("d")));
        Console.WriteLine(JsonSerializer.Serialize(hashTable.Get("z0")));
        
        hashTable.Delete("z0");
        hashTable.Update("z0", new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
        
        hashTable.Update("h", new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
        
        
        var hashTableGuids = new HashTable<string>(100_000); //25_000 = 20_000 + 25%;

        //Warmup
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        hashTableGuids.Insert(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
        hashTableGuids.Get(Guid.NewGuid().ToString());
        
        //Inserting 10_000 random strings twice, doubles the time of execution.
        //This is because the hash table has a table with a length of 100_000 and is only uses 750 positions (bad hashing?)
        //This cause a complexity between O(1) and O(n).
        var guids = new List<string>();
        for (int i = 0; i < 20_000; i++)
        {
            guids.Add(Guid.NewGuid().ToString());
        }
        
        ConsoleStopwatch.Start("Insert 10_000 guids");
        foreach (var guid in guids.Take(10_000))
        {
            hashTableGuids.Insert(guid, guid);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Insert 10_000 guids");
        foreach (var guid in guids.Skip(10_000))
        {
            hashTableGuids.Insert(guid, guid);
        }
        ConsoleStopwatch.Stop();
        
        hashTableGuids.Insert(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
        
        //Get by key is in optimal circumstances O(1), but in worst case O(n).
        foreach (var guid in guids.Take(5))
        {
            ConsoleStopwatch.Start("Get guid");
            hashTableGuids.Get(guid);
            ConsoleStopwatch.Stop();
        }
    }
}