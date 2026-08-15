public class Solution {
    public string MinWindow(string s, string t) {
          Dictionary<char, int> sFrequency = new();
    Dictionary<char, int> tFrequency = new();

    foreach (var c in t)
    {
        tFrequency[c] = tFrequency.GetValueOrDefault(c, 0) + 1;
    }

    int minStart = 0;
    int minLength = int.MaxValue;
    for (int l = 0, r = 0; r < s.Length; r++)
    {
        sFrequency[s[r]] = sFrequency.GetValueOrDefault(s[r], 0) + 1;
        // compare frequencies and
        // Whenever the correct is permutation is found try and decrease until
        // the same frequency exists
        while (Matches(sFrequency, tFrequency))
        {
            int windowLength = r - l + 1;
            // Save smallest window
            if (windowLength < minLength)
            {
                minLength = windowLength;
                minStart = l;
            }

            sFrequency[s[l]]--;
            if (sFrequency[s[l]] == 0)
            {
                sFrequency.Remove(s[l]);
            }
            l++;
        }
    }
    // compare and store the min string;

    return minLength == int.MaxValue
        ? ""
        : s.Substring(minStart, minLength);
    }

bool Matches(Dictionary<char, int> window, Dictionary<char, int> target)
{
    foreach (var (key, requiredCount) in target)
    {
        if (!window.TryGetValue(key, out int actualCount))
            return false;
        if (actualCount < requiredCount)
            return false;
    }
    return true;
}
}