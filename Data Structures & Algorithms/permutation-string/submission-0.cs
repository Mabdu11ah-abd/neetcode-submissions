public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

    Dictionary<char, int> map = new();
    Dictionary<char, int> matchingMap = new();

    foreach (char c in s1) {
        map[c] = map.GetValueOrDefault(c, 0) + 1;
    }

    for (int r = 0, l = 0; r < s2.Length; r++) {
        char incoming = s2[r];
        matchingMap[incoming] = matchingMap.GetValueOrDefault(incoming, 0) + 1;

        if (r - l + 1 > s1.Length) {
            char outgoing = s2[l];
            matchingMap[outgoing]--;
            if (matchingMap[outgoing] == 0) {
                matchingMap.Remove(outgoing); 
            }
            l++;
        }

        if (r - l + 1 == s1.Length && Matches(map, matchingMap)) {
            return true;
        }
    }

    return false;
    }

    bool Matches(Dictionary<char, int> map, Dictionary<char, int> matchingMap) {
    if (map.Count != matchingMap.Count) return false;

    foreach (var (key, val) in map) {
        if (!matchingMap.TryGetValue(key, out int count) || count != val) {
            return false;
        }
    }
    return true;
}
}
