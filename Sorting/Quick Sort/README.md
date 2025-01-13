# Quick Sort

The quick sort algorithm is a divide-and-conquer algorithm that divides the input array into two parts, recursively sorts the two parts, and then combines the results. It is a comparison-based sorting algorithm that is widely used due to its efficiency and simplicity.

## Key Concepts

1. **Input:** An unsorted array of elements.
2. **Output:** A sorted array in ascending or descending order.
3. **Logic:**
   - Choose a pivot element from the array.
   - Partition the array into two parts: elements less than the pivot and elements greater than the pivot.
   - Recursively apply the quick sort algorithm to the two parts.
   - Combine the sorted parts to get the final sorted array.
   - The pivot element is placed in its correct position in the sorted array.
   - The process is repeated until the entire array is sorted.
4. **Time Complexity:** `O(n log n)` on average, `O(n^2)` in the worst case.

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
