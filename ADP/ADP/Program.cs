using System.Text.Json;
using ADP.Dataset;
using ADP.Operations.Deque;
using ADP.Sorting.MergeSort;
using ADP.Sorting.QuickSort;
using ADP.TestObjects;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

int[] array = { 3, 6, 9, 4, 2, 1, 8, 7, 10, 5 };

var mergeSortTests = new MergeSortTests();
mergeSortTests.Run(datasetSorting);

