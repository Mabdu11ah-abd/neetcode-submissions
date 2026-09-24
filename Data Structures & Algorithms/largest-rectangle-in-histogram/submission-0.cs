public class Solution {
    public int LargestRectangleArea(int[] heights) {
        // rectangle  = height * width.
        int largestArea = 0;
        Stack<int> stack = new();
        // stack while height = greater than last one. 

        for(int i = 0; i <= heights.Length ;i++)
        {
            int currentHeight = (i == heights.Length) ? 0 : heights[i];

            while(stack.Count > 0 && currentHeight < heights[stack.Peek()] )
            {
                int heightIndex = stack.Pop();
                int height = heights[heightIndex];

                int width = (stack.Count == 0) ? i : (i - stack.Peek() - 1);

                largestArea = Math.Max(largestArea, height*width );
            }

            stack.Push(i);
        }
        // pop when height less than the 
        return largestArea;
}}
