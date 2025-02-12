# Sliding Window

The **Sliding Window** technique is used to perform a specific operation on a fixed-size window of elements in an array or a string. It involves creating a window that slides over the array or string, updating the window's contents, and keeping track of the maximum or minimum value within the window.

## Key Concepts
1. **Input:** An array of numbers or a string, a window size, and a specific operation to perform.
2. **Output:** The result of the operation performed on each window of elements.
3. **Logic:**
   - Initialize two pointers, `left` and `right`, to define the window's boundaries.
   - Move the `right` pointer to expand the window until the desired size is reached.
   - Perform the operation on the elements within the window.
   - Move the `left` pointer to shrink the window while maintaining the window size.
   - Update the result based on the operation performed on the window.
   - Repeat this process until the `right` pointer reaches the end of the array or string.
4. **Time complexity:** `O(n)`, where `n` is the number of elements in the array or string.

## C# Implementation

```csharp
public static void SlidingWindowAlgorithm(int[] nums, int k)
{
    int left = 0;
    int right = 0;

    while (right < nums.Length)
    {
        // Expand the window
        // Perform some operations using the window

        while (/* Condition to shrink the window */)
        {
            // Shrink the window
            // Perform some operations using the window
            left++;
        }

        right++;
    }
}

public static void SlidingWindowAlgorithm(int[] nums)
{
    var windowSum = 0;
    var windowStart = 0;
    var windowEnd = 0;
    
    for (windowEnd = 0; windowEnd < nums.Length; windowEnd++)
    {
        // Add the next element to the window
        windowSum += nums[windowEnd];
        
        // Check if the window size is greater than or equal to k
        if (windowEnd >= k - 1)
        {
            // Perform some operations using the window
            // Subtract the first element of the window
            windowSum -= nums[windowStart];
            windowStart++;
        }
    }
}

```


## Solutions

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0003. Longest Substring Without Repeating Characters](/Sliding%20Window%2F0003.%20Longest%20Substring%20Without%20Repeating%20Characters): Find the length of the longest substring without repeating characters

[0209. Minimum Size Subarray Sum](/Sliding%20Window%2F0209.%20Minimum%20Size%20Subarray%20Sum): Find the smallest contiguous subarray with a sum greater than or equal to a given target

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0030. Substring with Concatenation of All Words](/Sliding%20Window%2F0030.%20Substring%20with%20Concatenation%20of%20All%20Words): Find substring containing concatenation of all words in a list

[0076. Minimum Window Substring](/Sliding%20Window%2F0076.%20Minimum%20Window%20Substring): Find the minimum-length substring containing all characters of another string
