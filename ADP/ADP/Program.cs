using System.Text.Json;
using ADP.Dataset;
using ADP.Operations.Deque;
using ADP.Operations.HashTable;
using ADP.Sorting.MergeSort;using ADP.Sorting.QuickSort;
using ADP.TestObjects;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));
var datasetHashing = JsonSerializer.Deserialize<DatasetHashing>(File.ReadAllText("Dataset/dataset_hashing.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

new HashTableTests()
    .Run(datasetHashing);
