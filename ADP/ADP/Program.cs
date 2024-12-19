using System.Text.Json;
using ADP.Dataset;
using ADP.Operations.Deque;
using ADP.Sorting.MergeSort;
using ADP.TestObjects;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

int[] array = { 3, 1, 2, 4, 6, 5, 8, 7, 10, 9 };

MergeSort<int>.Sort(array);

var result = array;