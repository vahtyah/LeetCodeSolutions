public class Solution {
    public int Compress(char[] chars) {
        if (chars.Length < 2) return chars.Length;

        int index = 0; // Pointer to modify the array
        int count = 1; // Counter for consecutive characters

        for (int i = 1; i <= chars.Length; i++) {
            if (i < chars.Length && chars[i] == chars[i - 1]) {
                count++;
            } else {
                // Write the character
                chars[index++] = chars[i - 1];

                // If count > 1, write the count as characters
                if (count > 1) {
                    foreach (char c in count.ToString()) {
                        chars[index++] = c;
                    }
                }

                // Reset the count
                count = 1;
            }
        }

        return index;
    }
}