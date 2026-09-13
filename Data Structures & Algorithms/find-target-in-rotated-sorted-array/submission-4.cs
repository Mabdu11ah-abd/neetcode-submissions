public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0; int r = nums.Length -1;
        int length = nums.Length -1;

        while(l <= r)
        {
            int mid = l + (r - l) / 2;
            if(nums[mid] == target){
                return mid;
            }

            if(nums[l] <= nums[mid])
            {
                if(nums[mid] < target || target < nums[l])
                {
                    l = ( mid + 1 );
                }
                else
                {
                    r = ( mid - 1 );
                }
            }
            else{
                if(nums[mid] > target || target > nums[r])
                {
                    r = ( mid - 1 );
                }
                else
                {
                    l = ( mid + 1 );
                }

            }
        }
        return -1;
    }
}



// this is the array 3, 4, 5, 6, 1, 2;

// l = 0, r = 2;

// mid = 1

// r < l
// r = 0;



