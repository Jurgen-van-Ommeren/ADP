using ADP.Dataset;

namespace ADP.Operations.HashTable;

public class HashTableTests
{
    public void Run(DatasetHashing datasetHashing)
    {
        var hashTable = new HashTable<int[]>(datasetHashing.Hashtabelsleutelswaardes.Count);

        foreach (var datasetHashingHashtabelsleutelswaarde in datasetHashing.Hashtabelsleutelswaardes)
        {
            hashTable.Insert(datasetHashingHashtabelsleutelswaarde.Key, datasetHashingHashtabelsleutelswaarde.Value);
        }
    }
}