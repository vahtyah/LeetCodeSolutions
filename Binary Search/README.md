# Binary Search Algorithm

The **Binary Search** algorithm is an efficient technique used to search for a target element in a sorted array. It works by repeatedly dividing the search interval in half until the target element is found or the interval is empty.

## Key Concepts

1. **Input:** A sorted array of numbers (e.g., `int[] nums`) and a target element (e.g., `int target`).
2. **Output:** Output: The index of the target element in the array if it exists; otherwise, return `-1`.
3. **Logic:**
   - Initialize two pointers, `left` and `right`, to the start and end of the array, respectively.
   - While `left <= right`, calculate the `mid` index as `(left + right) / 2`.
   - If the target element is equal to the element at the `mid` index, return `mid`.
   - If the target element is less than the element at the `mid` index, set `right = mid - 1` to search the left half.
   - If the target element is greater than the element at the `mid` index, set `left = mid + 1` to search the right half.
4. **Time complexity:** `O(log n)`

## C# Implementation

```csharp
public static int BinarySearch(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (nums[mid] == target)
        {
            return mid;
        }
        else if (nums[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return -1;
}
```
## Use Cases

- **Searching in Sorted Arrays:** Quickly find the index of a target element in a sorted array.
```csharp
int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13 };
int targetIndex = BinarySearch(sortedArray, 7); // Returns 3
```
- **Finding the Square Root:** Use binary search to find the square root of a number with a given precision.
```csharp
double SquareRoot(double x, double precision)
{
    double left = 0;
    double right = x;
    double mid = 0;

    while (right - left > precision)
    {
        mid = left + (right - left) / 2;
        if (mid * mid > x)
        {
            right = mid;
        }
        else
        {
            left = mid;
        }
    }

    return mid;
}
```
- **Finding the Peak Element:** Use binary search to find the peak element in an array.
```csharp
int FindPeakElement(int[] nums)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left < right)
    {
        int mid = left + (right - left) / 2;
        if (nums[mid] < nums[mid + 1])
        {
            left = mid + 1;
        }
        else
        {
            right = mid;
        }
    }

    return left;
}
```
