namespace LeetCodeSolutions.DynamicProgramming;

/*
 * 1931. Painting a Grid With Three Different Colors
 * Difficulty: Hard
 * Submission Time: 2025-05-18 07:03:35
 * Created by vahtyah on 2025-05-18 07:04:03
*/
 
public class Solution
{
    private const int MOD = 1_000_000_007;
    private int m, n;
    private List<List<int>> states;
    private List<List<int>> transitions;

    public int ColorTheGrid(int m_input, int n_input)
    {
        m = m_input;
        n = n_input;
        states = new List<List<int>>();
        
        //Build all valid columns using backtracking(make sure columns are not the same color)
        BuildColumns(new List<int>());

        int K = states.Count; // Number of valid columns

        //Build transition graph between valid columns
        transitions = new List<List<int>>(new List<int>[K]);
        for (int i = 0; i < K; ++i)
            transitions[i] = new List<int>();

        for (int i = 0; i < K; ++i)
        {
            for (int j = 0; j < K; ++j)
            {
                if (IsCompatible(states[i], states[j]))
                    transitions[i].Add(j);
            }
        }

        //Dynamic programming
        var dp = new int[K];
        for (int i = 0; i < K; ++i)
            dp[i] = 1; // Base case: one way to start with any column

        // We now use dynamic programming (DP) to count the total number of ways
        // to build the entire grid, column by column, following allowed transitions.

        // Loop over all columns from 1 to n-1
        // (we already assume column 0 is "placed" with any valid starting column)
        for (int col = 1; col < n; ++col)
        {
            // Create a new DP array to hold the number of ways for each state at this column
            // newDp[i] will represent: number of ways to reach state 'i' at column 'col'
            var newDp = new int[K];

            // For every possible column state 'i' at this column
            for (int i = 0; i < K; ++i)
            {
                // Loop through all previous column states that can legally transition into 'i'
                // (precomputed earlier in 'transitions[i]')
                foreach (var prev in transitions[i])
                {
                    // Add the number of ways to reach 'prev' from last column
                    // to the number of ways to reach 'i' now
                    // (modulo is used to prevent integer overflow)
                    newDp[i] = (newDp[i] + dp[prev]) % MOD;
                }
            }

            // Move to the next column
            // Now 'dp' becomes 'newDp', and we continue for the next column
            dp = newDp;
        }

        // Step 4: Sum all ways for the last column
        int total = 0;
        foreach (var count in dp)
            total = (total + count) % MOD;

        return total;
    }

    // Backtracking to generate all valid columns
    // BuildColumns will generate all the column combinations in an order that won't allow for same colored columns
    private void BuildColumns(List<int> current)
    {
        if (current.Count == m)
        {
            states.Add(new List<int>(current));
            return;
        }

        for (int color = 0; color < 3; ++color)
        {
            if (current.Count > 0 && current[current.Count - 1] == color)
                continue;

            current.Add(color);
            BuildColumns(current);
            current.RemoveAt(current.Count - 1);
        }
    }

    // Check two columns compatibility (horizontal conflict)
    private bool IsCompatible(List<int> a, List<int> b)
    {
        for (int i = 0; i < m; ++i)
        {
            if (a[i] == b[i])
                return false;
        }
        return true;
    }
}