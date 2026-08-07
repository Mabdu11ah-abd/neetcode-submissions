public class Solution {
    public bool hasDuplicate(int[] nums) {
Dictionary<int, int> map = new();

        foreach(var num in nums)
        {
            if(!map.ContainsKey(num))
            {
                map[num] = 0;   
            }           
            else if(map.ContainsKey(num))
            {
                Console.WriteLine(num);
                return true;
            }
        }   

        return false;
    }
}