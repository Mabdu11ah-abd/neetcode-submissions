
public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> sol = new();
        for(int i = 0; i < nums.Length-1; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int target = -nums[i];
            int k = i+1;
            int j = nums.Length - 1;
            while(k < j)
            {
                var temp = (nums[k] + nums[j]);
                if(target == temp)
                {
                    // create list and add it to sol 
                    sol.Add(new List<int> { nums[i], nums[k], nums[j] });
                    
                    k++;
                    j--;

                    while (k < j && nums[k] == nums[k - 1])
                        k++;

                    while (k < j && nums[j] == nums[j + 1])
                        j--;
                }
                else if (temp > target)
                {
                    j--;
                }
                else if(temp < target)
                {
                    k++;
                }
            }
        }

        return sol;
    }
}