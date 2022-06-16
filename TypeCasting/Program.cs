// Type Casting
// Implicit vs Explicit Type Casting

int a;
a = 10;
    // a = "10"; will cause an error
    // a is an int, not a string


// Implicit Conversion
// Implicit conversion is when the compiler converts a value from one type to another.
int num = 10000;
long bigNum = num; 
    // This will implicitly convert num to a long

// Explicit Conversion
// Explicit conversion is conversion given a specific type.
double num2 = 3.14;
int num3 = (int)num2; 
    // This will explicitly convert num2 to an int
    // A double cannot be implicitly converted to an int

// Real World Example of Type Casting/Conversion
// string value = "1234"; // First condition met
string value = "LMAO"; // Second condition met
int result = 0;
if(int.TryParse(value, out result)) // out is a keyword that is used to pass a variable as an output parameter
{
    Console.WriteLine("SUCCESS: " + result);
}
    // This will convert the string value to an int and assign it to result

else
{
    Console.WriteLine("The string could not be converted to an int.");
}
    // This will print "The string could not be converted to an int."