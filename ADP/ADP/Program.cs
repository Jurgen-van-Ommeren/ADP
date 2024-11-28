using System.Text.Json;
using ADP.Dataset;
using ADP.Operations.Deque;
using ADP.Operations.DynamicArray;
using ADP.Operations.PriorityQueue;
using ADP.Operations.Stack;
using ADP.TestObjects;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(2000);

var dynamicArrayTests = new DynamicArrayTests();
dynamicArrayTests.Run(datasetSorting);

// var priorityQueueTests = new PriorityQueueTests();
// priorityQueueTests.Run(datasetSorting);

// var stackTests = new StackTests();
// stackTests.Run(datasetSorting);
  