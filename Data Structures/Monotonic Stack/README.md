# Monotonic Stack

A monotonic stack is a data structure that is used to solve problems related to finding the next greater or smaller element in an array. It is a stack that either strictly increases or decreases in value. The stack is used to keep track of elements that have not yet found their next greater or smaller element.

## Key Concepts

1. **Monotonic Stack:**
   - A monotonic stack is a stack that either strictly increases or decreases in value.
   - It is used to find the next greater or smaller element in an array.
   - The stack stores elements that have not yet found their next greater or smaller element.
   - The elements in the stack are processed in a way that maintains the monotonic property.
   - The stack can be implemented using a list or a deque in Python or a stack in C#.
   - The stack is used to keep track of elements that have not yet found their next greater or smaller element.

2. **Applications:**
    - Monotonic stacks are commonly used to solve problems related to finding the next greater or smaller element in an array.
    - They are used in problems that require finding the nearest element that satisfies a certain condition.
3. **Time Complexity:** O(N), where N is the number of elements in the array.

## C# Implementation

```csharp

public class MonotonicStack
{
    public int[] NextGreaterElement(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = n - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && stack.Peek() <= nums[i])
            {
                stack.Pop();
            }

            result[i] = stack.Count > 0 ? stack.Peek() : -1;
            stack.Push(nums[i]);
        }

        return result;
    }
    
    public int[] NextSmallerElement(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = n - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && stack.Peek() >= nums[i])
            {
                stack.Pop();
            }

            result[i] = stack.Count > 0 ? stack.Peek() : -1;
            stack.Push(nums[i]);
        }

        return result;
    }
}

```
## Solutions

[//]: # (### ![Easy]&#40;https://img.shields.io/badge/Easy-46c6c2&#41;)

### ![Medium](https://img.shields.io/badge/Medium-fac31d)

[0739. Daily Temperatures](https://github.com/vahtyah/LeetCodeSolutions/tree/main/Data%20Structures/Monotonic%20Stack/0739.%20Daily%20Temperatures): Find the number of days you would have to wait until a warmer temperature.



