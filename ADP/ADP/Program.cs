using System.Text.Json;
using ADP.Dataset;
using ADP.Sorting.BinarySearch;
using ADP.TestObjects;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

var binarySearchTests = new BinarySearchTests();

// binarySearchTests.RunFunctionalTests();
binarySearchTests.Run(datasetSorting);