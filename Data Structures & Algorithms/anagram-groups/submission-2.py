class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res = defaultdict(list)

        for string in strs: 
            count = [0] * 26

            for characters in string : 
                count[ord(characters) - ord('a')] += 1
                
            res[tuple(count)].append(string)
        return list(res.values())