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

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[2379. Minimum Recolors to Get K Consecutive Black Blocks](/Sliding%20Window%2F2379.%20Minimum%20Recolors%20to%20Get%20K%20Consecutive%20Black%20Blocks): Find minimum white blocks to recolor for `k` black

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0003. Longest Substring Without Repeating Characters](/Sliding%20Window%2F0003.%20Longest%20Substring%20Without%20Repeating%20Characters): Find the length of the longest substring without repeating characters

[0209. Minimum Size Subarray Sum](/Sliding%20Window%2F0209.%20Minimum%20Size%20Subarray%20Sum): Find the smallest contiguous subarray with a sum greater than or equal to a given target

[1358. Number of Substrings Containing All Three Characters](/Sliding%20Window%2F1358.%20Number%20of%20Substrings%20Containing%20All%20Three%20Characters): Count substrings containing 'a', 'b', and 'c'

[2401. Longest Nice Subarray](/Sliding%20Window%2F2401.%20Longest%20Nice%20Subarray): Find the longest subarray with pairwise bitwise AND zero

[2537. Count the Number of Good Subarrays](/Sliding%20Window%2F2537.%20Count%20the%20Number%20of%20Good%20Subarrays): Count subarrays with at least K equal pairs

[2799. Count Complete Subarrays in an Array](/Sliding%20Window%2F2799.%20Count%20Complete%20Subarrays%20in%20an%20Array): Count subarrays containing all distinct array values

[2962. Count Subarrays Where Max Element Appears at Least K Times](/Sliding%20Window%2F2962.%20Count%20Subarrays%20Where%20Max%20Element%20Appears%20at%20Least%20K%20Times): Count subarrays with at least K occurrences of max

[3208. Alternating Groups II](/Sliding%20Window%2F3208.%20Alternating%20Groups%20II): Find longest substring with alternating adjacent group sizes

[3306. Count of Substrings Containing Every Vowel and K Consonants II](/Sliding%20Window%2F3306.%20Count%20of%20Substrings%20Containing%20Every%20Vowel%20and%20K%20Consonants%20II): Count substrings with all vowels and K consonants

[3439. Reschedule Meetings for Maximum Free Time I](/Sliding%20Window%2F3439.%20Reschedule%20Meetings%20for%20Maximum%20Free%20Time%20I): Maximize free time by optimally rescheduling meeting intervals

### ![Hard](https://img.shields.io/badge/Hard-f8615c)

[0030. Substring with Concatenation of All Words](/Sliding%20Window%2F0030.%20Substring%20with%20Concatenation%20of%20All%20Words): Find substring containing concatenation of all words in a list

[0076. Minimum Window Substring](/Sliding%20Window%2F0076.%20Minimum%20Window%20Substring): Find the minimum-length substring containing all characters of another string

[2302. Count Subarrays With Score Less Than K](/Sliding%20Window%2F2302.%20Count%20Subarrays%20With%20Score%20Less%20Than%20K): Count subarrays where sum times length is less than K

[2444. Count Subarrays With Fixed Bounds](/Sliding%20Window%2F2444.%20Count%20Subarrays%20With%20Fixed%20Bounds): Count subarrays where min=minK and max=maxK

[3445. Maximum Difference Between Even and Odd Frequency II](/Sliding%20Window%2F3445.%20Maximum%20Difference%20Between%20Even%20and%20Odd%20Frequency%20II): Maximize (even frequency sum) - (odd frequency sum)
