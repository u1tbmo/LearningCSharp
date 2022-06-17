// Arrays are used to store multiple values of the same type in a single variable.

/*
A fixed array is an array that is fixed in size. The size of the array is known at compile time.
A dynamic array is an array that is dynamic in size. The size of the array is not known at compile time.
*/

// FIXED ARRAYS

 // fixed size array of 5 ints // initializes all values to 0
int[] intArray = new int[5];

// fixed size array of 5 strings // initializes all values to null
string[] stringArray = new string[5]; 

// DO NOT DO IN A PRODUCTION ENVIRONMENT // initializes all values to null
object[] objectArray = new object[5];

// Arrays are zero-based. The first index is 0, the second index is 1, and so on.
intArray[0] = 10;
intArray[1] = 20;
intArray[2] = 30;
intArray[3] = 40;
intArray[4] = 50;

// intArray[] = {10, 20, 30, 40, 50}

stringArray[0] = "Hello";
stringArray[1] = "World";
stringArray[2] = "!";
stringArray[3] = "!";
stringArray[4] = "!";

// stringArray[] = {"Hello", "World", "!", "!", "!"}    

// Prints value of intArray[0]
Console.WriteLine(intArray[0]);

// Prints value of stringArray[0]
Console.WriteLine(stringArray[0]);

// DYNAMIC ARRAYS

// Creates an array of 5 ints and initializes all values to 10, 20, 30, 40, 50
int[] intArray2 = new int[] {10, 20, 30, 40, 50}; // The size of the array can be changed at runtime

Console.WriteLine(intArray2[0]); 

intArray2[0] = 100; // Changes the value of intArray2[0] from 10 to 100

Console.WriteLine(intArray2[0]); 
