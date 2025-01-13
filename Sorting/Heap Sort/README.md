# Heap Sort

The heap sort algorithm is a comparison-based sorting algorithm that uses a binary heap data structure. It is an in-place algorithm with a time complexity of `O(n log n)`.

## Key Concepts

1. **Input:** An unsorted array of numbers.
2. **Output:** A sorted array in ascending or descending order.
3. **Logic:**
   - Build a max heap from the input array.
   - Swap the root node with the last node and reduce the heap size by one.
   - Heapify the remaining elements to maintain the max heap property.
   - Repeat the process until the heap size is one.
   - The array is now sorted in ascending order.
4. **Time complexity:** `O(n log n)`

## C# Implementation

```csharp
public static void InsertionSort(int[] nums)
{
    int n = nums.Length;

    for (int i = 1; i < n; i++)
    {
        int key = nums[i];
        int j = i - 1;

        while (j >= 0 && nums[j] > key)
        {
            nums[j + 1] = nums[j];
            j--;
        }

        nums[j + 1] = key;
    }
}
```

[//]: # (## Solutions)

[//]: # (### ![Easy]&#40;https://img.shields.io/badge/Easy-46c6c2&#41;)

[//]: # (### ![Medium]&#40;https://img.shields.io/badge/Medium-fac31d&#41;)
