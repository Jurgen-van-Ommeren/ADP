using System.Text.Json;
using ADP.Dataset;
using ADP.Graph;
using ADP.Graph.Dijkstra;
using ADP.Operations.Deque;
using ADP.Operations.HashTable;
using ADP.Sorting.MergeSort;using ADP.Sorting.QuickSort;
using ADP.TestObjects;
using ADP.Trees;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));
var datasetGraphs = JsonSerializer.Deserialize<DatasetGraphs>(File.ReadAllText("Dataset/dataset_grafen.json"));
var datasetHashing = JsonSerializer.Deserialize<DatasetHashing>(File.ReadAllText("Dataset/dataset_hashing.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

// var graphTest = new GraphTests();
//
// graphTest.RunFunctionalTests(datasetGraphs);

// var dijkstraTest = new DijkstraShortestPathTests();
//
// dijkstraTest.Run(datasetGraphs);

// new AvlTreeTest().Run();

new HashTableTests()
    .Run(datasetHashing);

