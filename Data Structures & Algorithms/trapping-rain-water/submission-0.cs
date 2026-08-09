public class Solution {
    public int Trap(int[] height) {
        
        int amount = 0;
        int []left  = new int[height.Length];
        int []right  = new int[height.Length];
        int leftmax = 0, rightmax = 0;
        for(int i = 0, j = height.Length-1; i < height.Length; i++ ,j--)
        {
            if(i > 0 )
            {
                if(leftmax < height[i-1])
                {
                    leftmax = height[i-1];
                }
            }
            left[i]  = leftmax;
            
            if(j < height.Length-1)
            {
                if(rightmax < height[j+1])
                {
                    rightmax = height[j+1];
                }
            }
            right[j]  = rightmax;
        }

        for(int i = 0; i< height.Length; i++)
        {
            int sum  = Math.Min(right[i],left[i]) - height[i];
            if(sum > 0)
                amount += sum;
        }
        return amount;
    }
}
