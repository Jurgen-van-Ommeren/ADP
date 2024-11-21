using ADP.ADT_Operations.Doubly_Linked_Lists;
using ADP.ADT_Operations.DynamicArray;
using ADP.ADT_Operations.Stack;

var dynamicArrayTests = new DynamicArrayTests();
var stackTests = new StackTests();

// dynamicArrayTests.TestAddFunction();
// dynamicArrayTests.TestGetFunction();
// dynamicArrayTests.TestSetFunction();
// dynamicArrayTests.TestRemoveFunction();
// dynamicArrayTests.TestRemoveElementFunction();
// dynamicArrayTests.TestContainsFunction();
//dynamicArrayTests.TestIndexOfFunction();

stackTests.TestStack();

var doubleLinkedListTest = new DoubleLinkedListTest();
doubleLinkedListTest.Run();
