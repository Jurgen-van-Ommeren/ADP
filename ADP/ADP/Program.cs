using System.Text.Json;
using ADP.Dataset;
using ADP.Operations.DoublyLinkedLists;
using ADP.Operations.DynamicArray;
using ADP.Operations.PriorityQueue;
using ADP.Sorting.SelectionSort;
using ADP.TestObjects;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

var selectionSortTests = new SelectionSortTests();

selectionSortTests.RunTests(datasetSorting);
