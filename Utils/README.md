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
### Bit Manipulation
```csharp
    
// Set a bit at position i
int setBit = num | (1 << i);

// Clear a bit at position i
int clearBit = num & ~(1 << i);

// Toggle a bit at position i
int toggleBit = num ^ (1 << i);

// Check if a bit at position i is set
bool isSet = (num & (1 << i)) != 0;

// Get the rightmost set bit
int rightmostSetBit = num & -num;

// Count the number of set bits
int countBits = 0;
while(n > 0) {
    countBits += n & 1;
    n >>= 1;
}
```

### GCD & LCM
```csharp
// GCD (Greatest Common Divisor)
public int GCD(int a, int b) {
    while(b != 0) {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

// LCM (Least Common Multiple)
public int LCM(int a, int b) {
    return (a * b) / GCD(a, b);
}
```

