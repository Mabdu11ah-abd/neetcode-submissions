class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t) :
            return False

        my_dict = {}
        
        for s_char, t_char in zip(s, t) : 
            my_dict[s_char] = my_dict.get(s_char, 0) + 1;
            my_dict[t_char] = my_dict.get(t_char, 0) - 1;

        for count in my_dict.values() : 
            if count != 0 : 
                return False 
        
        return True


        

            
            