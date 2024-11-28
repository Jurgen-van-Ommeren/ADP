using System.Text.Json;
using ADP.Dataset;
using ADP.Operations.Deque;
using ADP.Operations.DynamicArray;
using ADP.Operations.PriorityQueue;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));

var dynamicArrayTests = new DynamicArrayTests();

dynamicArrayTests.Run(datasetSorting);
