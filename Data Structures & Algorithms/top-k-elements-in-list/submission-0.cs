public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new();
        foreach(var num in nums)
        {
            if(!map.ContainsKey(num))
            {
                map[num] = 1;
            }
            else
            {
                map[num]++;
            }
        }


        return map
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}
