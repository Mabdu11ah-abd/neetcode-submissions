public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers.Length <= 1 ) return [];
        // solving this problem in brute force is easy
        int l = 0, r = numbers.Length-1;

        while(l <= r)
        {
            var leftNum = numbers[l];
            var rightNum = numbers[r];

            int sum = leftNum +rightNum;

            if(sum == target)
            {
                return new int [] {l+1, r+1};
            }

            else if(sum > target)
            {
                r--;
            }
            else if(sum < target)
            {
                l++;
            }
        }
        

        return new int[] {};
    }
}
