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

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[0013. Roman to Integer](/Data%20Structures%2FString%2F0013.%20Roman%20to%20Integer): Convert Roman numeral string to an integer

[0014. Longest Common Prefix](/Data%20Structures%2FString%2F0014.%20Longest%20Common%20Prefix): Find the longest common prefix shared among a set of strings

[0058. Length of Last Word](/Data%20Structures%2FString%2F0058.%20Length%20of%20Last%20Word): Find length of last word in a string

[0205. Isomorphic Strings](/Data%20Structures%2FString%2F0205.%20Isomorphic%20Strings): Determine if two strings are isomorphic by mapping characters

[0242. Valid Anagram](/Data%20Structures%2FString%2F0242.%20Valid%20Anagram): Determine if two strings are anagrams of each other

[1790. Check if One String Swap Can Make Strings Equal](/Data%20Structures%2FString%2F1790.%20Check%20if%20One%20String%20Swap%20Can%20Make%20Strings%20Equal): Swap any two characters of one string to check if equal to another

[2138. Divide a String Into Groups of Size k](/Data%20Structures%2FString%2F2138.%20Divide%20a%20String%20Into%20Groups%20of%20Size%20k): Divide string into k-sized groups; pad if needed

[2942. Find Words Containing Character](/Data%20Structures%2FString%2F2942.%20Find%20Words%20Containing%20Character): Find words containing a given character

[3174. Clear Digits](/Data%20Structures%2FString%2F3174.%20Clear%20Digits): Remove all digits from a given string

[3330. Find the Original Typed String I](/Data%20Structures%2FString%2F3330.%20Find%20the%20Original%20Typed%20String%20I): Reconstruct original string after duplicate characters are added

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0006. Zigzag Conversion](/Data%20Structures%2FString%2F0006.%20Zigzag%20Conversion): Convert a string into a zigzag pattern

[0012. Integer to Roman](/Data%20Structures%2FString%2F0012.%20Integer%20to%20Roman): Convert an integer into its Roman numeral representation

[0038. Count and Say](/Data%20Structures%2FString%2F0038.%20Count%20and%20Say): Generate the next RLE number string based on the previous

[0151. Reverse Words in a String](/Data%20Structures%2FString%2F0151.%20Reverse%20Words%20in%20a%20String): Reverse the order of words in a string while preserving spaces

[0916. Word Subsets](/Data%20Structures%2FString%2F0916.%20Word%20Subsets): Find all words from `B` that are universal in `A`

[3223. Minimum Length of String After Operations](/Data%20Structures%2FString%2F3223.%20Minimum%20Length%20of%20String%20After%20Operations): Find the minimum length of a string after applying operations

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0068. Text Justification](/Data%20Structures%2FString%2F0068.%20Text%20Justification): Left-justify, right-justify, or center-justify text with variable word spacing
