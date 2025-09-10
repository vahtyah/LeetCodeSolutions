namespace LeetCodeSolutions.DataStructures/HashTable;

/*
 * 1733. Minimum Number of People to Teach
 * Difficulty: Medium
 * Submission Time: 2025-09-10 13:05:45
 * Created by vahtyah on 2025-09-10 13:07:26
*/
 
public class Solution {
    public int MinimumTeachings(int n, int[][] languages, int[][] friendships) {
        var m = languages.Length;

        var knows = new HashSet<int>[m + 1];
        for (int i = 1; i <= m; i++)
        {
            knows[i] = [.. languages[i - 1]];
        }

        var needUsers = new HashSet<int>();
        foreach (var f in friendships)
        {
            int u = f[0], v = f[1];
            if (!ShareLanguage(knows[u], knows[v]))
            {
                needUsers.Add(u);
                needUsers.Add(v);
            }
        }

        if (needUsers.Count == 0) return 0;

        var knowCount = new int[n + 1];
        foreach (int user in needUsers)
            foreach (int lang in knows[user])
                knowCount[lang]++;

        var ans = int.MaxValue;
        var need = needUsers.Count;
        for (int lang = 1; lang <= n; lang++)
            ans = Math.Min(ans, need - knowCount[lang]);

        return ans;
    }

    private bool ShareLanguage(HashSet<int> a, HashSet<int> b)
    {
        if (a.Count > b.Count) { var t = a; a = b; b = t; }
        foreach (var x in a) if (b.Contains(x)) return true;
        return false;
    }
}