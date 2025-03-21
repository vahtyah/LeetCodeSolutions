namespace LeetCodeSolutions.Searching/Breadth-FirstSearch;

/*
 * 2115. Find All Possible Recipes from Given Supplies
 * Difficulty: Medium
 * Submission Time: 2025-03-21 05:23:44
 * Created by vahtyah on 2025-03-21 05:27:58
*/
 
public class Solution {
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies) 
    {
        var graph = new Dictionary<string, List<string>>();
        var inDegree = new Dictionary<string, int>();
        
        for (int i = 0; i < recipes.Length; i++) 
        {
            inDegree[recipes[i]] = 0;
        }
        
        for (int i = 0; i < recipes.Length; i++) 
        {
            foreach (var ingredient in ingredients[i]) 
            {
                if (!graph.ContainsKey(ingredient))
                {
                    graph[ingredient] = new List<string>();
                }
                graph[ingredient].Add(recipes[i]);
                inDegree[recipes[i]]++;
            }
        }
        
        var queue = new Queue<string>(supplies);
        var result = new List<string>();
        
        //Topological sort
        while (queue.Count > 0) 
        {
            var current = queue.Dequeue();
            
            if (!graph.ContainsKey(current)) continue;
            
            foreach (var recipe in graph[current]) 
            {
                inDegree[recipe]--;
                
                if (inDegree[recipe] == 0) 
                {
                    result.Add(recipe);
                    queue.Enqueue(recipe); 
                }
            }
        }
        
        return result;
    }
}