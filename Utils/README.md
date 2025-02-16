### Optimize

- **AggressiveInlining** - This attribute tells the compiler to optimize the method for performance. It is useful when the method is small and called frequently.
```csharp
using System.Runtime.CompilerServices;

public Solution {
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Method() {
        // Code here
    }
}
```
- Span<T> - Span<T> is a new type in C# that provides a way to work with contiguous regions of arbitrary memory in a safe and efficient manner. It is useful for avoiding unnecessary memory allocations and improving performance.
```csharp
using System;
   
public Solution {
    public void Method() {
        int[] array = new int[10];
        Span<int> span = new Span<int>(array);
        // Use the span here
    }
}
```
- **Memory<T>** - Memory<T> is another type that represents a contiguous region of memory, similar to Span<T>. It is read-only and can be used to avoid unnecessary memory allocations.
```csharp
using System;

public Solution {
    public void Method() {
        int[] array = new int[10];
        Memory<int> memory = new Memory<int>(array);
        // Use the memory here
    }
}
```

### Match
```csharp
// Check odd or even using bitwise operator
bool isOdd = (num & 1) == 1;
bool isEven = (num & 1) == 0;

// Swap two numbers without using a temporary variable
a ^= b;
b ^= a;
a ^= b;

// Check if a number is a power of two
bool isPowerOfTwo = (num & (num - 1)) == 0;

// Round up/down to multiple of k
int roundUp = (num + k - 1) / k * k; // 1.2 -> 2, 1.7 -> 2
int roundDown = num / k * k; // 1.2 -> 1, 1.7 -> 1

// Calculate mid without overflow
int mid = left + (right - left) / 2;
int mid = left + (right - left) >> 1; // Faster alternative

// Ensure a number is within the range [low, high]
num = Math.Max(num, low);
num = Math.Min(num, high);

//Ensure positive modulo [0, k)
int mod = ((num % k) + k) % k;

// Toggle a bit at position i
num ^= (1 << i);

// Check if a number is negative
bool isNegative = (num >> 31) == -1;

// Get the absolute value of a number
int abs = (num ^ (num >> 31)) - (num >> 31);

// Get the maximum of two numbers
int max = b ^ ((a ^ b) & -Convert.ToInt32(a > b));

// Get the minimum of two numbers
int min = a ^ ((a ^ b) & -Convert.ToInt32(a < b));

// Check if two numbers have the same sign
bool sameSign = (a ^ b) >= 0;

// Get the sign of a number
int sign = (num >> 31) | Convert.ToInt32(num == 0);

// Swap the sign of a number
int swapSign = ~num + 1;

// Get the average of two numbers
int average = (a & b) + ((a ^ b) >> 1);
```

