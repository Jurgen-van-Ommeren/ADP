using System.Text.Json;
using ADP.Dataset;
using ADP.Operations.DoublyLinkedLists;
using ADP.Operations.DynamicArray;
using ADP.Operations.PriorityQueue;
using ADP.TestObjects;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

// var dynamicArrayTests = new DynamicArrayTests();
// dynamicArrayTests.Run(datasetSorting);

var priorityQueueTests = new PriorityQueueTests();
priorityQueueTests.Run(datasetSorting);

// var stackTests = new StackTests();
// stackTests.Run(datasetSorting);

// var dynamicArrayTests = new DynamicArrayTests();
//
// dynamicArrayTests.Run(datasetSorting);

// new PriorityQueueWithArrayTest()
//     .Run(datasetSorting);

// new DequeTest()
//     .Run(datasetSorting);
    
// new DoubleLinkedListTest()
//     .Run(datasetSorting);