# Binary Search

The **Binary Search** algorithm is an efficient technique used to search for a target element in a sorted array. It works by repeatedly dividing the search interval in half until the target element is found or the interval is empty.

## Key Concepts

1. **Input:** A sorted array of numbers (e.g., `int[] nums`) and a target element (e.g., `int target`).
2. **Output:** The index of the target element in the array if it exists; otherwise, return `-1`.
3. **Logic:**
   - Initialize two pointers, `left` and `right`, to the start and end of the array, respectively.
   - While `left <= right`, calculate the `mid` index as `(left + right) / 2`.
   - If the target element is equal to the element at the `mid` index, return `mid`.
   - If the target element is less than the element at the `mid` index, set `right = mid - 1` to search the left half.
   - If the target element is greater than the element at the `mid` index, set `left = mid + 1` to search the right half.
   - Repeat the process until the target element is found or the interval is empty.
   - If the target element is not found, return `-1`.
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
        //int mid = left + ((right - left) >> 1); // Alternative faster way to calculate mid

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

## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[0035. Search Insert Position](/Searching%2FBinary%20Search%2F0035.%20Search%20Insert%20Position): Find index to insert target in sorted array

[0069. Sqrt(x)](/Searching%2FBinary%20Search%2F0069.%20Sqrt%28x%29): Find the integer square root of a nonnegative integer

[2529. Maximum Count of Positive Integer and Negative Integer](/Searching%2FBinary%20Search%2F2529.%20Maximum%20Count%20of%20Positive%20Integer%20and%20Negative%20Integer): Find the max count of positive/negative numbers in array

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0033. Search in Rotated Sorted Array](/Searching%2FBinary%20Search%2F0033.%20Search%20in%20Rotated%20Sorted%20Array): Find target in a rotated sorted array

[0034. Find First and Last Position of Element in Sorted Array](/Searching%2FBinary%20Search%2F0034.%20Find%20First%20and%20Last%20Position%20of%20Element%20in%20Sorted%20Array): Find first and last index of target in sorted array

[0057. Insert Interval](/Searching%2FBinary%20Search%2F0057.%20Insert%20Interval): Merge non-overlapping intervals after inserting a new interval

[0074. Search a 2D Matrix](/Searching%2FBinary%20Search%2F0074.%20Search%20a%202D%20Matrix): Find if a target exists in a sorted 2D matrix

[0153. Find Minimum in Rotated Sorted Array](/Searching%2FBinary%20Search%2F0153.%20Find%20Minimum%20in%20Rotated%20Sorted%20Array): Find the minimum element in a rotated sorted array

[0162. Find Peak Element](/Searching%2FBinary%20Search%2F0162.%20Find%20Peak%20Element): Find the peak element in an array

[0300. Longest Increasing Subsequence](/Searching%2FBinary%20Search%2F0300.%20Longest%20Increasing%20Subsequence): Find the length of the longest increasing subsequence

[0373. Find K Pairs with Smallest Sums](/Searching%2FBinary%20Search%2F0373.%20Find%20K%20Pairs%20with%20Smallest%20Sums): Find k pairs with smallest sums from two arrays

[0875. Koko Eating Bananas](/Searching%2FBinary%20Search%2F0875.%20Koko%20Eating%20Bananas): Koko eats bananas at varying speeds; find the minimum speed to finish all

[2226. Maximum Candies Allocated to K Children](/Searching%2FBinary%20Search%2F2226.%20Maximum%20Candies%20Allocated%20to%20K%20Children): Maximize equal candy piles distributed to K children

[2300. Successful Pairs of Spells and Potions](/Searching%2FBinary%20Search%2F2300.%20Successful%20Pairs%20of%20Spells%20and%20Potions): Maximize the number of potions that can be made with given spells and ingredients

[2560. House Robber IV](/Searching%2FBinary%20Search%2F2560.%20House%20Robber%20IV): Find the minimum capacity to rob **k** houses

[2594. Minimum Time to Repair Cars](/Searching%2FBinary%20Search%2F2594.%20Minimum%20Time%20to%20Repair%20Cars): Find min time to repair all cars with given ranks

[2616. Minimize the Maximum Difference of Pairs](/Searching%2FBinary%20Search%2F2616.%20Minimize%20the%20Maximum%20Difference%20of%20Pairs): Find minimum max-difference, forming p pairs

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0004. Median of Two Sorted Arrays](/Searching%2FBinary%20Search%2F0004.%20Median%20of%20Two%20Sorted%20Arrays): Find median of two sorted arrays merged implicitly

[2040. Kth Smallest Product of Two Sorted Arrays](/Searching%2FBinary%20Search%2F2040.%20Kth%20Smallest%20Product%20of%20Two%20Sorted%20Arrays): Find the kth smallest product from two sorted arrays
