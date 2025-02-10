# Data Structures/Stack

Stack is a linear data structure that follows the Last In First Out (LIFO) principle. The last element added to the stack is the first one to be removed. The operations of a stack are as follows:

## Key Concepts

1. **Push:** Add an element to the top of the stack.
2. **Pop:** Remove the top element from the stack.
3. **Peek:** Get the top element of the stack without removing it.
4. **Empty:** Check if the stack is empty.
5. **Size:** Get the number of elements in the stack.
7. **Time Complexity:** O(1) for push, pop, peek, empty, and size operations.
8. **Space Complexity:** O(N), where N is the number of elements in the stack.

## C# Implementation

```csharp
public class Stack<T>
{
    private List<T> stack;

    public Stack()
    {
        stack = new List<T>();
    }

    public void Push(T value)
    {
        stack.Add(value);
    }

    public T Pop()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        T value = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return value;
    }

    public T Peek()
    {
        if (stack.Count == 0)
        {
            throw new InvalidOperationException("The stack is empty.");
        }

        return stack[stack.Count - 1];
    }

    public bool Empty()
    {
        return stack.Count == 0;
    }

    public int Size()
    {
        return stack.Count;
    }
}

public class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Pop()); // Output: 3
        Console.WriteLine(stack.Peek()); // Output: 2
        Console.WriteLine(stack.Size()); // Output: 2
        Console.WriteLine(stack.Empty()); // Output: False
    }
}
```


## Solutions

### ![Easy](https://img.shields.io/badge/Easy-46c6c2)

[3174. Clear Digits](/Data%20Structures%2FStack%2F3174.%20Clear%20Digits): Remove digits from a string to minimize the resulting integer
