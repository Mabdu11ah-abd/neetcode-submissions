public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        Dictionary<char, int> count = new();

        int res = 0;
        int l = 0;

        for (int r = 0; r < s.Length; r++)
        {
            if (!count.ContainsKey(s[r]))
            {
                count[s[r]] = 1;
            }
            else
            {
                count[s[r]]++;
            }

            while ((r - l + 1) - count.Values.Max() > k)
            {
                count[s[l]]--;
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}