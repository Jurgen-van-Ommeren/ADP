using System.Text.Json;
using ADP.Dataset;

namespace ADP.Operations.HashTable;

public class HashTableTests
{
    public void Run(DatasetHashing datasetHashing)
    {
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
    }
}