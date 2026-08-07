public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new();

        for(int i = 0; i < nums.Length; i++ )
        {   
            var compliment = target - nums[i];
            if(map.ContainsKey(compliment))
            {
                return [map[compliment], i];
            }
            if(!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }
        return [];
    }
}
