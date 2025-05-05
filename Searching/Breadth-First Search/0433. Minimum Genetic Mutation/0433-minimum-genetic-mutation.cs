namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 0433. Minimum Genetic Mutation
 * Difficulty: Medium
 * Submission Time: 2025-05-05 07:47:04
 * Created by vahtyah on 2025-05-05 07:48:12
*/
 
public class Solution {
    private static readonly char[] GeneChars = { 'A', 'C', 'G', 'T' };
    
    public int MinMutation(string startGene, string endGene, string[] bank) {
        if (Array.IndexOf(bank, endGene) == -1) 
            return -1;
            
        var bankSet = new HashSet<string>(bank);
        var visited = new bool[bank.Length];
        
        var queue = new Queue<(string gene, int level)>();
        queue.Enqueue((startGene, 0));
        
        int endIndex = Array.IndexOf(bank, endGene);
        
        while (queue.Count > 0) {
            var (currentGene, mutations) = queue.Dequeue();
            
            if (currentGene == endGene)
                return mutations;
                
            for (int i = 0; i < bank.Length; i++) {
                if (visited[i]) 
                    continue;
                    
                if (IsSingleMutation(currentGene, bank[i])) {
                    if (i == endIndex)
                        return mutations + 1;
                        
                    visited[i] = true;
                    queue.Enqueue((bank[i], mutations + 1));
                }
            }
        }
        
        return -1; 
    }
    
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    private bool IsSingleMutation(string gene1, string gene2) {
        int diffCount = 0;
        for (int i = 0; i < 8; i++) {
            if (gene1[i] != gene2[i]) {
                diffCount++;
                if (diffCount > 1) 
                    return false;
            }
        }
        return diffCount == 1;
    
    }
}