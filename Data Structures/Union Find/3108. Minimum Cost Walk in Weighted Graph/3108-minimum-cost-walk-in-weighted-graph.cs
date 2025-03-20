namespace LeetCodeSolutions.DataStructures/UnionFind;

/*
 * 3108. Minimum Cost Walk in Weighted Graph
 * Difficulty: Hard
 * Submission Time: 2025-03-20 05:37:42
 * Created by vahtyah on 2025-03-20 05:38:14
*/
 
public class Solution {
    public int[] MinimumCost(int n, int[][] edges, int[][] query) {
        var q = query.Length;
        var parents = new int[n];
        var ranks = new int[n];
        var costs = new int[n];
        
        for (var i = 0; i < n; i++) {
            parents[i] = i;
            costs[i] = -1;
        }

        foreach (var edge in edges) {
            Union(edge[0], edge[1], edge[2]);
        }

        var res = new int[q];
        for (var i = 0; i < q; i++) {
            var x = Find(query[i][0]);
            var y = Find(query[i][1]);
            res[i] = x == y ? costs[x] : -1;
        }

        return res;

        int Find(int x) {
            if (parents[x] == x) {
                return x;
            }
            parents[x] = Find(parents[x]);
            return parents[x];
        }

        void Union(int x, int y, int cost) {
            x = Find(x);
            y = Find(y);
            
            if (x == y) {
                costs[x] &= cost;
                return;
            }

            if (ranks[x] < ranks[y]) {
                (x, y) = (y, x);
            }

            costs[x] = costs[x] & costs[y] & cost;
            parents[y] = x;
            if (ranks[x] == ranks[y]) {
                ranks[x]++;
            }
        }
    }
}