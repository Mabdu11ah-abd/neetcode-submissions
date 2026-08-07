public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> sol = new();

        foreach(var str in strs)
        {
            char[] sortedarray = str.ToCharArray();
            Array.Sort(sortedarray);
            
            string sortedstring = new string(sortedarray);

            if(!sol.ContainsKey(sortedstring))
            {
                sol[sortedstring] = new List<String>();
            }
            sol[sortedstring].Add(str);
        }
        return sol.Values.ToList<List<string>>();
    }
}
