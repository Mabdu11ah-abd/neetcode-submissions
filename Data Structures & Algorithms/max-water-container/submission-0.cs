public class Solution {
    public int MaxArea(int[] heights) 
    {
        int currentmax = 0;
for (int i = 0, j = heights.Length - 1; i < j; )
{
    // calculate the maximum amount of water 
    var amount = Math.Min(heights[i], heights[j]) * (j - i);

    if (amount > currentmax)
    {
        currentmax = amount;
    }

    if (heights[i] > heights[j])
    {
        j--;
    }
    else
    {
        i++;
    }
}
        return currentmax;
    }
}
