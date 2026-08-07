public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0 ) return "";
        StringBuilder solution = new();

        foreach(var str in strs)
        {
            solution.Append(str.Length);
            solution.Append("#");
            solution.Append(str);
        }

        return solution.ToString();
    }

    public List<string> Decode(string s) {
        List<string> sol = new();
        if( s.Length == 0 )  {
            return sol;
        }
        int i = 0;
        while (i < s.Length)
        {
            // Find the '#'
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }
            // Parse the length
            int length = int.Parse(s.Substring(i, j - i));
            // Move past '#'
            j++;
            // Extract the string
            string str = s.Substring(j, length);
            sol.Add(str);
            // Move to the next encoded string
            i = j + length;
    }
    return sol;
   }
}
