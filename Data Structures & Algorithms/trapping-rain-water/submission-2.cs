public class Solution {
    public int Trap(int[] height) {
        if(height.Length == 0) return 0;

        int l = 0, r = height.Length -1;
        int leftmax = height[l];
        int rightmax = height[r];
        int amount = 0;

        while(l < r )
        {
            if(leftmax < rightmax)
            {
                l++;
                leftmax = Math.Max(leftmax, height[l]);
                amount += leftmax - height[l];
            }
            else
            {
                r--;
                rightmax = Math.Max(rightmax, height[r]);
                amount +=  rightmax - height[r];
            }
        }
        return amount;
    }
}
