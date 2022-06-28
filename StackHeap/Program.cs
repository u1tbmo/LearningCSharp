// Stack is used for value types.
// Heap is used for reference types.

using StackHeap;

int value = 10; // value is a value type, it will be stored in the stack

byte lowLevelValue = 2; // lowLevelValue is a value type, it will be stored in the stack

bool Bool = true; // Bool is a value type, it will be stored in the stack

string phrase = "Hello World"; // phrase is a reference type, it will be stored in the heap

StackHeapObject stackHeap = new StackHeapObject(); // stackHeap is a reference type, it will be stored in the heap
Console.WriteLine(value);
stackHeap.AddTwo(value); // calls AddTwo on the stackHeap object, returning value + 2L
Console.WriteLine(value); 

// Remove CS0219 Errors
Console.WriteLine(lowLevelValue);
Console.WriteLine(Bool);
Console.WriteLine(phrase);