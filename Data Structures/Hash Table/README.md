# Hash Table

**Hash Table** is a data structure that stores key-value pairs. It uses a hash function to compute an index into an array of buckets or slots, from which the desired value can be found.

## C# Key Points

### Dictionary Initialization
```csharp
Dictionary<string, int> dict = new Dictionary<string, int>();
```

### Adding/Updating Elements
```csharp
dict["apple"] = 5; // Add or update the value for the key "apple"
```

### Checking if a Key Exists
```csharp
if (dict.ContainsKey("apple"))
{
    // Key exists
}
```

### Accessing Values
```csharp
int value = dict["apple"]; // Get the value for the key "apple"
```

### Removing Elements
```csharp
dict.Remove("apple"); // Remove the key-value pair with the key "apple"
```

### Iterating Over Key-Value Pairs
```csharp
foreach (var pair in dict)
{
    string key = pair.Key;
    int value = pair.Value;
}
```

### Dictionary Methods
- `ContainsKey`: Checks if a key exists in the dictionary.
- `TryGetValue`: Tries to get the value associated with the specified key.
- `Keys`: Returns a collection of the dictionary's keys.
- `Values`: Returns a collection of the dictionary's values.
- `Clear`: Removes all key-value pairs from the dictionary.
- `Count`: Returns the number of key-value pairs in the dictionary.
- `ToArray`: Converts the dictionary to an array of key-value pairs.
- `Contains`: Checks if the dictionary contains a specific key-value pair.
- `Remove`: Removes the key-value pair with the specified key.
- `Add`: Adds the specified key and value to the dictionary.
- `TryAdd`: Tries to add the specified key and value to the dictionary.
- `TryUpdate`: Tries to update the value associated with the specified key.
- `TryRemove`: Tries to remove the key-value pair with the specified key.
- `GetValueOrDefault`: Gets the value associated with the specified key, or a default value if the key is not found.
- `GetOrAdd`: Gets the value associated with the specified key, or adds a new key-value pair if the key is not found.
- `AddOrUpdate`: Adds a new key-value pair or updates an existing key-value pair.
- `ToDictionary`: Converts an `IEnumerable` to a dictionary.
- `OrderBy`: Orders the elements of a sequence by a specified key.
- `GroupBy`: Groups the elements of a sequence based on a key selector function.
- `Join`: Correlates the elements of two sequences based on matching keys.
- `ToLookup`: Creates a lookup from an `IEnumerable` based on a key selector function.

## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[0001. Two Sum](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Hash%20Table/0001.%20Two%20Sum): Find two numbers that add up to a specific target.

[1768. Merge Strings Alternately](/Data%20Structures%2FHash%20Table%2F1768.%20Merge%20Strings%20Alternately): Merge two strings alternately, character by character

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0380. Insert Delete GetRandom O(1)](/Data%20Structures%2FHash%20Table%2F0380.%20Insert%20Delete%20GetRandom%20O%281%29): Design a data structure that supports insert, delete, and getRandom operations in constant time.
