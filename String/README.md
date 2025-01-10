# String

**String** is a sequence of characters used to represent text. It is a reference type and is immutable, meaning once a string is created, it cannot be modified directly. If you modify a string, a new string is created instead.

## C# Key Points
### Declaring and Initializing a String
```csharp
string greeting = "Hello, World!";
```
### Common methods
- `Length`: Returns the number of characters in the string.
````csharp
int length = greeting.Length; // 13
````
- `Substring`: Returns a new string that is a substring of the original string.
````csharp
string subString = greeting.Substring(7); // "World!"
string subString = greeting.Substring(7, 5); // "World"
````

- `IndexOf`: Returns the index of the first occurrence of a character or substring in the string.
````csharp
int index = greeting.IndexOf("World"); // 7
````

- `Contains`: Returns a boolean indicating whether a character or substring is present in the string.
````csharp
bool contains = greeting.Contains("Hello"); // true
````

- `Replace`: Replaces all occurrences of a specified character or substring with another character or substring.
````csharp
string newString = greeting.Replace("Hello", "Hi"); // "Hi, World!"
````

- `Split`: Splits a string into an array of substrings based on a specified separator.
````csharp
string[] words = greeting.Split(","); // ["Hello", " World!"]
````

- `Trim`: Removes all leading and trailing white-space characters from the string.
````csharp
string trimmedString = "  Hello, World!  ".Trim(); // "Hello, World!"
````

- `ToUpper` and `ToLower`: Converts the string to uppercase or lowercase.
````csharp
string upperCase = greeting.ToUpper(); // "HELLO, WORLD!"
string lowerCase = greeting.ToLower(); // "hello, world!"
````

- `StartsWith` and `EndsWith`: Returns a boolean indicating whether the string starts or ends with a specified character or substring.
````csharp
bool startsWith = greeting.StartsWith("Hello"); // true
bool endsWith = greeting.EndsWith("World!"); // true
````

- `Concat`: Concatenates two or more strings.
````csharp
string name = "Alice";
string message = string.Concat("Hello, ", name); // "Hello, Alice"
````

- `Format`: Replaces each format item in a specified string with the text equivalent of a corresponding object's value.
````csharp
string formattedString = string.Format("Hello, {0}!", name); // "Hello, Alice!"
````

- `Join`: Concatenates the elements of a specified array or collection, using a specified separator between each element.
````csharp
string[] words = { "Hello", "World" };
string joinedString = string.Join(" ", words); // "Hello World"
````

- `IsNullOrEmpty`: Returns a boolean indicating whether the string is null or empty.
````csharp
bool isNullOrEmpty = string.IsNullOrEmpty(greeting); // false
````

- `IsNullOrWhiteSpace`: Returns a boolean indicating whether the string is null, empty, or consists only of white-space characters.
````csharp
bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace("   "); // true
````

### String Interpolation
String interpolation allows you to embed expressions into a string literal. It is denoted by the `$` symbol before the string and curly braces `{}` around the expressions.
````csharp
string name = "Alice";
string message = $"Hello, {name}!"; // "Hello, Alice!"
````

### Verbatim String Literal
A verbatim string literal is prefixed by the `@` symbol and allows you to include newline characters and escape sequences without using double backslashes.
````csharp
string path = @"C:\Users\Alice\Documents";
````
### StringBuilder
`StringBuilder` is a mutable string type that allows you to efficiently build and manipulate strings without creating new string instances.
````csharp
StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append("World");
string result = sb.ToString(); // "HelloWorld"
````

### String Comparison
When comparing strings, you can use the `==` operator, but it compares the references of the strings, not the actual content. To compare the content of strings, you can use the `Equals` method with the `StringComparison` parameter.
````csharp
string str1 = "Hello";
string str2 = "Hello";
bool areEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase); // true
````
### String Equality
To compare strings for equality, you can use the `==` operator, but it compares the references of the strings, not the actual content. To compare the content of strings, you can use the `Equals` method with the `StringComparison` parameter.
````csharp
string str1 = "Hello";
string str2 = "Hello";
bool areEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase); // true
````
### String Concatenation
When concatenating strings, you can use the `+` operator, but it creates a new string instance each time. For better performance, especially when concatenating multiple strings in a loop, you can use `StringBuilder`.
````csharp
string result = "Hello" + "World"; // "HelloWorld"
````
### String Immutability
Strings in C# are immutable, meaning that once a string is created, it cannot be modified. Any operation that appears to modify a string actually creates a new string instance.
````csharp
string str = "Hello";
str += "World"; // Creates a new string instance
````

## Solutions

[//]: # (![Easy]&#40;https://img.shields.io/badge/Easy-46c6c2&#41;)

![Medium](https://img.shields.io/badge/Medium-fac31d)

[0916. Word Subsets](https://github.com/vahtyah/LeetCodeSolutions/tree/main/String/0916.%20Word%20Subsets): Find all words from a list that are universal to a set of words.
