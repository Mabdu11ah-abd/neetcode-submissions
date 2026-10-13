class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        my_dict = {}

        for i, num in enumerate(nums) : 
            compliment = target - num

            if num in my_dict : 
                return [my_dict[num], i]


            my_dict[compliment] = i
        