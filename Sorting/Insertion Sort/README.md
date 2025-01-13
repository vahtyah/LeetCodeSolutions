# Insertion Sort

The **Insertion Sort** algorithm is a simple sorting algorithm that builds the final sorted list one element at a time. It is much less efficient on large lists than more advanced algorithms such as quicksort, heapsort, or merge sort.

## Key Concepts

1. **Input:** An unsorted array of numbers (e.g., `int[] nums`).
2. **Output:** A sorted array of numbers.
3. **Logic:**
   - Start with the second element and compare it with the elements to its left.
   - Insert the element at the correct position in the sorted part of the array.
   - Repeat this process for all elements in the array.
   - The array is divided into two parts: a sorted part and an unsorted part.
   - The sorted part is initially empty and grows as elements are inserted.
   - The unsorted part contains all the remaining elements.
   - The algorithm iterates over the unsorted part, comparing each element with the elements in the sorted part and inserting it at the correct position.
   - The process continues until all elements are sorted.
   - The array is sorted in place, and the original array is modified.
4. **Time complexity:** `O(n^2)` in the worst case, `O(n)` in the best case (when the array is already sorted).

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
