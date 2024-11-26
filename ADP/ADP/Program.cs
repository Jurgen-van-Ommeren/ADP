using System.Text.Json;
using ADP.Dataset;
using ADP.Operations.Deque;
using ADP.Operations.PriorityQueue;

var datasetSorting = JsonSerializer.Deserialize<DatasetSorting>(File.ReadAllText("Dataset/dataset_sorteren.json"));

// var dynamicArrayTests = new DynamicArrayTests();
// var stackTests = new StackTests();
//
// dynamicArrayTests.TestAddFunction();
// dynamicArrayTests.TestGetFunction();
// dynamicArrayTests.TestSetFunction();
// dynamicArrayTests.TestRemoveFunction();
// dynamicArrayTests.TestRemoveElementFunction();
// dynamicArrayTests.TestContainsFunction();
// dynamicArrayTests.TestIndexOfFunction();
//
// stackTests.TestStack();

// var doubleLinkedListTest = new DoubleLinkedListTest();
// doubleLinkedListTest.Run(datasetSorting);

// var dequeTest = new DequeTest();
// dequeTest.Run(datasetSorting);

var priorityQueuTest = new PriorityQueueWithArrayTest();
priorityQueuTest.Run(datasetSorting);
