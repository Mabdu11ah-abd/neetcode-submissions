public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // first things first, need to store both the index, and the number of days a tuple would be useful 

        // secondly, increasing number of days after each one right

        // brute force solution is super simple just on2
        int n = temperatures.Length;
        int []sol = new int[n]; 
        Stack<(int index, int temp)> stack = new();
        for(int i = 0; i< temperatures.Length ; i++)
        {
            int currentTemp = temperatures[i];

            while(stack.Count> 0 && currentTemp > stack.Peek().temp)
            {
                var (prevIndex, prevTemprature) = stack.Pop();
                sol[prevIndex] = i - prevIndex;
            }
            stack.Push((i, currentTemp));
        }
        
        return sol;
    }
}



