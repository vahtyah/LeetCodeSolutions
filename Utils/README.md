### Optimize

- **AggressiveInlining** - This attribute tells the compiler to optimize the method for performance. It is useful when the method is small and called frequently.
```csharp
public class Solution {
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public void Method() {
        // Code here
    }
}
```

- **Unsafe code** - This allows you to perform low-level memory operations, which can be useful for performance-critical applications. Use with caution as it bypasses type safety.
```csharp
public static void UnsafeOperations()
{
    unsafe
    {
        int* ptr = stackalloc int[10]; // Allocate memory on the stack
        for (int i = 0; i < 10; i++)
        {
            ptr[i] = i; // Directly manipulate memory
        }
    }
    
    // Use when: Performance critical, low-level memory access, interop with native code
    
    int[] array = { 1, 2, 3, 4, 5 };
    fixed (int* p = array) // Pin the array in memory
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(p[i]); // Access elements directly
        }
    }
    
    // Use when: Interop with native libraries, performance critical scenarios
}
```

- **Span** and **Memory** are types that allow you to work with slices of arrays or other memory regions without copying data. They are useful for high-performance scenarios where you want to avoid unnecessary allocations.

```csharp
//1. Using Span<T> to manipulate an array
public static void SpanFromArray()
{
    int[] array = new int[5] { 1, 2, 3, 4, 5 };
    Span<int> span = array; // Implicit conversion from array to Span<int>
    span[0] = 10; // Modify original array
    // Use when: Have existing array, need to modify data, large datasets
}

//2. Span<T> from stackalloc - Use for temporary buffers, high performance
public static void SpanFromStackalloc()
{
    Span<int> span = stackalloc int[5]; // Allocates a span on the stack
    span.Fill(0); // Initialize all elements to 0
    // Use when: Buffer < 1KB, temporary calculations, high performance
}

// 3. ReadOnlySpan from String - Use for string processing
public static void ReadOnlySpanFromString()
{
    string str = "Hello, World!";
    ReadOnlySpan<char> readOnlySpan = str.AsSpan(); // Convert string to ReadOnlySpan<char>
    ReadOnlySpan<char> hello = span[..5]; // No allocation
    // Use when: Parse string, slice text, avoid allocations
}

// 4. Span Slicing - Use when need part of data
public static void SpanSlicing()
{
    int[] data = new int[100];
    Span<int> full = data;
    Span<int> first = full[..50];    // First half
    Span<int> last = full[50..];     // Second half
    // Use when: Process chunks, regions, avoid copying data
}

// 5. Unsafe Span - Use for interop, performance critical
public static unsafe void UnsafeSpan()
{
    int* ptr = stackalloc int[10];
    Span<int> span = new Span<int>(ptr, 10);
    // Use when: Interop, native libraries, custom memory management
}

// 6. Memory<T> - Use for async operations
public static async Task MemoryForAsync()
{
    Memory<int> memory = new int[100];
    await ProcessAsync(memory); // Can await
    Span<int> span = memory.Span; // Convert when needed
    // Use when: Async/await, store in fields, long-lived buffers
}

// 7. MemoryMarshal - Advanced operations
public static void MemoryMarshalOps()
{
    Span<int> ints = stackalloc int[4];
    Span<byte> bytes = MemoryMarshal.AsBytes(ints); // Reinterpret
    // Use when: Type casting, binary protocols, performance critical
}

// 8. Empty Span - Use for edge cases
public static void EmptySpan()
{
    Span<int> empty = Span<int>.Empty;
    if (!empty.IsEmpty) { /* process */ }
    // Use when: Default values, safety checks
}

private static async Task ProcessAsync(Memory<int> memory)
{
    await Task.Delay(1);
}

// CHEAT SHEET:
// • Span<T>: Synchronous, high performance, stack only
// • Memory<T>: Async, storage, heap/stack
// • ReadOnlySpan<T>: No modification, string processing
// • stackalloc: < 1KB, temporary
// • Array: Large data, long-lived
// • Unsafe: Interop, extreme performance
```



