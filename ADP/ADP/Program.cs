using System.Text.Json;
using ADP.Dataset;
using ADP.Graph;
using ADP.Operations.Deque;
using ADP.Sorting.MergeSort;using ADP.Sorting.QuickSort;
using ADP.TestObjects;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));
var datasetGraphs = JsonSerializer.Deserialize<DatasetGraphs>(File.ReadAllText("Dataset/dataset_grafen.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

var graphTest = new GraphTests();

graphTest.RunFunctionalTests(datasetGraphs);