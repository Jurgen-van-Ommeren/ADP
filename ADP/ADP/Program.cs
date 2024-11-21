using System.Text.Json;
using ADP.ADT_Operations.Doubly_Linked_Lists;
using ADP.Dataset;

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

var doubleLinkedListTest = new DoubleLinkedListTest();
doubleLinkedListTest.Run(datasetSorting);
