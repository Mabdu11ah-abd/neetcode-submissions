public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length < 1) return s.Length;
        String longest = "";
        int max = 0;
        // this is a problem that involves a sliding window of dynamic size
        for (int j = 0; j < s.Length; j++)
        {
            if (longest.Contains(s[j]))
            {
                // Fix: Find the character's index inside the CURRENT window (longest)
                var index = longest.IndexOf(s[j]);
                
                // Slice off everything up to and including the duplicate
                longest = longest[(index + 1)..];
            }
            
            longest += s[j];
            max = Math.Max(max, longest.Length);
        }

        return max;

    }
}
