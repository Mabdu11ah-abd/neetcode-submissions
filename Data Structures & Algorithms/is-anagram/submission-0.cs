public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        Dictionary<char, int> map1 = new();
        Dictionary<char, int> map2 = new();

        for(int i = 0; i < s.Length ; i++)
        {
            if(!map1.ContainsKey(s[i]))
            {
                map1[s[i]] = 1; 
            }
            else
            {
                map1[s[i]] ++;
            }

            if(!map2.ContainsKey(t[i]))
            {
                map2[t[i]] = 1; 
            }
            else
            {
                map2[t[i]]++; 
            }
        }

        if (map1.Count != map2.Count)
    return false;

    foreach (var (key, value) in map1)
    {
        if (!map2.TryGetValue(key, out int other))
            return false;

        if (value != other)
            return false;
    }

    return true;
    }

}