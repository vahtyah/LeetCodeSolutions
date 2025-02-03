namespace LeetCodeSolutions.DataStructures/String;

/*
 * 0006. Zigzag Conversion
 * Difficulty: Medium
 * Submission Time: 2025-02-03 17:52:28
 * Created by vahtyah on 2025-02-03 17:52:47
 */
 
public class Solution
{
    public unsafe string Convert(string s, int rows)
    {
        // Handle the edge case where there's only one row
        // In this case, the zigzag pattern is irrelevant, and we can return the input string directly.
        if (rows == 1) { return s; }
        
        // Get the length of the input string.
        var length = s.Length;

        // Allocate memory on the stack for the output string using 'stackalloc' for performance.
        var output = stackalloc char[length];

        // Calculate the "stride" (the step size for zigzag traversal).
        // This is the total number of characters between two vertically aligned characters in the zigzag pattern.
        var stride = (rows - 1) * 2;

        // Initialize an index to track the position of the next character to be placed in the output.
        var index = 0;

        // Use a fixed pointer to access the input string's memory for efficient traversal.
        fixed (char* input = s)
        {
            // Iterate over each row of the zigzag pattern.
            for (var row = 0; row < rows; row++)
            {
                // Traverse the string in steps of the stride, processing characters for the current row.
                for (var i = 0; i < length + rows; i += stride)
                {
                    // Current character index in the zigzag pattern for this row.
                    var cur = row + i;

                    // Middle character index for rows that are not the top or bottom.
                    // This represents the character in the zigzag pattern between two vertical characters.
                    var mid = cur - row * 2;

                    // Add the middle character to the output if it exists in the bounds of the string
                    // and if the current row is not the first or the last row (no midpoints for them).
                    if (mid >= 0 && mid < length && row != 0 && row != rows - 1)
                    {
                        output[index++] = input[mid];
                    }

                    // Add the current character to the output if it exists within the string bounds.
                    if (cur >= 0 && cur < length)
                    {
                        output[index++] = input[cur];
                    }
                }
            }
        }

        // Create a new string from the stack-allocated memory and return it.
        return new string(output, 0, length);
    }
}