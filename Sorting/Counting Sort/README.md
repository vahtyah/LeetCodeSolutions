# Counting Sort

The counting sort algorithm is a sorting algorithm that sorts elements in a given array by counting the number of occurrences of each unique element and then using this information to determine the position of each element in the sorted output array.

## Key Concepts

1. **Input:** An array of numbers (e.g., `int[] input`).
2. **Output:** A sorted array of the same size as the input.
3. **Logic:**
   - Find the maximum value in the input array.
   - Create a count array to store the frequency of each element.
   - Calculate the cumulative sum of the count array to determine the position of each element in the sorted array.
   - Iterate through the input array and place each element in the correct position in the output array.
4. **Time complexity:** `O(n + k)`, where `n` is the number of elements in the input array and `k` is the range of the input values.

## C# Implementation

```csharp
public static int[] CountingSort(int[] input)
{
    int n = input.Length;
    int max = input.Max();
    int[] count = new int[max + 1];
    int[] output = new int[n];

    foreach (int num in input)
    {
        count[num]++;
    }

    for (int i = 1; i <= max; i++)
    {
        count[i] += count[i - 1];
    }

    for (int i = n - 1; i >= 0; i--)
    {
        output[count[input[i]] - 1] = input[i];
        count[input[i]]--;
    }

    return output;
}

// Usage
int[] input = { 4, 2, 2, 8, 3, 3, 1 };
int[] sortedArray = CountingSort(input);
Console.WriteLine(string.Join(", ", sortedArray)); // Output: 1, 2, 2, 3, 3, 4, 8
```

## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0274. H-Index](/Sorting%2FCounting%20Sort%2F0274.%20H-Index): Find the h-index of a researcher based on their citations.
