# Counting Sort

The counting sort algorithm is a sorting algorithm that sorts elements in a given array by counting the number of occurrences of each unique element and then using this information to determine the position of each element in the sorted output array.

## Key Concepts

- **Time complexity:** `O(n + k)`, where `n` is the number of elements in the input array and `k` is the range of the input values.
- Large space complexity due to the need for a count array.
- Needs a range of input values to be known beforehand.
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


Original: [4, 2, 2, 8, 3, 3, 1]

Count array (index 0-7 = value 1-8):
Index:  0  1  2  3  4  5  6  7
Value:  1  2  3  4  5  6  7  8
Count: [1, 2, 2, 1, 0, 0, 0, 1]

Cumulative count:
[1, 3, 5, 6, 6, 6, 6, 7]

Building result (từ phải sang trái):
- arr[6]=1: position = --count[0] = 0, result[0]=1
- arr[5]=3: position = --count[2] = 4, result[4]=3  
- arr[4]=3: position = --count[2] = 3, result[3]=3
- arr[3]=8: position = --count[7] = 6, result[6]=8
- arr[2]=2: position = --count[1] = 2, result[2]=2
- arr[1]=2: position = --count[1] = 1, result[1]=2
- arr[0]=4: position = --count[3] = 5, result[5]=4

Result: [1, 2, 2, 3, 3, 4, 8]
```

## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0215. Kth Largest Element in an Array](/Sorting%2FCounting%20Sort%2F0215.%20Kth%20Largest%20Element%20in%20an%20Array): Find the kth largest element in an unsorted array

[0274. H-Index](/Sorting%2FCounting%20Sort%2F0274.%20H-Index): Find the h-index of a researcher based on their citations.
