using System.Text.Json;
using ADP.Dataset;
using ADP.Graph;
using ADP.Graph.Dijkstra;
using ADP.Operations.Deque;
using ADP.Operations.DoublyLinkedLists;
using ADP.Operations.DynamicArray;
using ADP.Operations.HashTable;
using ADP.Operations.PriorityQueue;
using ADP.Operations.Stack;
using ADP.Sorting.BinarySearch;
using ADP.Sorting.InsertionSort;
using ADP.Sorting.MergeSort;using ADP.Sorting.QuickSort;
using ADP.Sorting.SelectionSort;
using ADP.Testing;
using ADP.TestObjects;
using ADP.Trees;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));
var datasetGraphs = JsonSerializer.Deserialize<DatasetGraphs>(File.ReadAllText("Dataset/dataset_grafen.json"));
var datasetHashing = JsonSerializer.Deserialize<DatasetHashing>(File.ReadAllText("Dataset/dataset_hashing.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

Console.WriteLine("Start DynamicArrayTests");
new DynamicArrayTests()
    .Run(datasetSorting);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start DoubleLinkedListTest");
new DoubleLinkedListTest()
    .Run(datasetSorting);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start StackTests");
new StackTests()
    .Run(datasetSorting);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start DequeTest");
new DequeTest()
    .Run(datasetSorting);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start PriorityQueueTests");
new PriorityQueueTests()
    .Run(datasetSorting);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start BinarySearchTests");
new BinarySearchTests()
    .Run(datasetSorting);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start InsertionSortTest");
new InsertionSortTest()
    .Run(datasetSorting);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start SelectionSortTests");
new SelectionSortTests()
    .Run(datasetSorting);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start QuickSortTest");
new QuickSortTest()
    .Run(datasetSorting);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start MergeSortTests");
new MergeSortTests()
    .Run(datasetSorting);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start HashTableTests");
new HashTableTests()
    .Run(datasetHashing);
Console.WriteLine();
Console.WriteLine();
    
Console.WriteLine("Start GraphTests");
new GraphTests()
    .Run(datasetGraphs);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start DijkstraShortestPathTests");
new DijkstraShortestPathTests()
    .Run(datasetGraphs);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Start AvlTreeTest");
new AvlTreeTest()
    .Run();
Console.WriteLine();
Console.WriteLine();
