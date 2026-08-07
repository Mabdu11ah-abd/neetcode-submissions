public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        Dictionary<int, List<int>> map = new();
        int length = nums.Length;
        int[] prefix = new int[length];
        int[] postfix = new int[length];

        // calculate the postfix and prefix
        for(int i = 0, j = length -1; i< length; i++, j--)
        {
            if(j == length-1 && i == 0 ){
                postfix[j] = nums[j];
                prefix[i] = nums[i];
            }
            else
            {
                postfix[j] = nums[j] * postfix[j + 1];
                prefix[i] = nums[i] * prefix[i -1];
            }
        }

        for (int i = 0; i < length; i++)
        {
            if (i == 0)
            {
                nums[i] = postfix[i + 1];
            }
            else if (i == length - 1)
            {
                nums[i] = prefix[i - 1];
            }
            else
            {
                nums[i] = prefix[i - 1] * postfix[i + 1];
            }
        }

        return nums;
    }
}
