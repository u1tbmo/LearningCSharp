// Strings are objects containing text.

// Strings are a reference type.

// string vs String

using System.Text;

string a = "Hello World";
String b = "Hello World";

// While both are equivalent, String has more extension methods.

string c; // This is a null string.

// IMPORTANT NOTE ON VALUE TYPES

// int randomNum = null; throws an error since int is a value type.

// Literal vs Verbatim String

string literalPath = "C:\\Program Files\\"; // Slashes need to be escaped.
string verbatimPath = @"C:\Program Files\"; // Ignores escape characters.

// String immutability (read-only)

string p1 = "Hello ";
string p2 = p1;
p1 += "World";

Console.WriteLine(p2);

// String Interpolation and Composite Formatting

string firstName = "Euan";
string lastName = "Tabamo";

Console.WriteLine($"My name is {firstName} {lastName}");
Console.WriteLine("My name is {0} {1}", firstName, lastName);

// String Builder

var sb = new StringBuilder();

var testStringBuilder = sb.Append(firstName);

Console.WriteLine(lastName);

// Remove CS0219 Errors
Console.WriteLine(a);
Console.WriteLine(b);

c = "Hello World"; // Assign a new value to c.
Console.WriteLine(c);

Console.WriteLine(literalPath);
Console.WriteLine(verbatimPath);
