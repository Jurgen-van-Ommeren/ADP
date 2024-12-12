using System.Text.Json;
using ADP.Dataset;
using ADP.TestObjects;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));

datasetSorting.Pizzas = PizzaGenerator.GenerateRandomPizzas(8001);

// var dynamicArray = new DynamicArray<Pizza>();
// var pizza = new Pizza
// {
//     Name = "test",
//     Slices = 15
// };
//
// dynamicArray.Add(datasetSorting.Pizzas[0]);
// dynamicArray.Add(datasetSorting.Pizzas[1]);
// dynamicArray.Add(datasetSorting.Pizzas[2]);
// dynamicArray.Add(datasetSorting.Pizzas[3]);
// dynamicArray.Add(datasetSorting.Pizzas[4]);
// dynamicArray.Add(pizza);
// dynamicArray.Add(datasetSorting.Pizzas[5]);
// dynamicArray.Add(datasetSorting.Pizzas[6]);
// dynamicArray.Add(datasetSorting.Pizzas[7]);
// dynamicArray.Add(datasetSorting.Pizzas[8]);
// dynamicArray.Add(datasetSorting.Pizzas[9]);
//
// dynamicArray.Remove(pizza);
// dynamicArray.Add(datasetSorting.Pizzas[10]);
//
// var test = dynamicArray;