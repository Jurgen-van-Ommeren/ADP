using System.Text.Json;
using ADP.Dataset;
using ADP.Operations.Deque;
using ADP.Sorting.MergeSort;using ADP.Sorting.QuickSort;
using ADP.TestObjects;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

new QuickSortTest()
    .Run(datasetSorting);
