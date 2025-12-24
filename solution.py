class Solution:
    def findWords(self, words: List[str]) -> List[str]:
        r1 = "qwertyuiop"
        r2 = "asdfghjkl"
        r3 = "zxcvbnm"

        ret = []
        for s in words:
            row = 0
            inv = False
            for c in s.lower():
                print(c)
                if c in r1:
                    if row >= 2:
                        inv = True
                        break
                    row = 1
                elif c in r2:
                    if row == 1 or row == 3:
                        inv = True
                        break
                    row = 2
                else:
                    if row == 1 or row == 2:
                        inv = True
                        break
                    row = 3
            
            if(not inv): ret.append(s)

        return ret
