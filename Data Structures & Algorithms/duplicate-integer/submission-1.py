class Solution:
    def hasDuplicate(self, nums: list[int]) -> bool:
        my_dict = {}

        for num in nums:
            my_dict[num] = my_dict.get(num, 0) + 1
        
        for val in my_dict.values():
            if val > 1:
                return True

        return False