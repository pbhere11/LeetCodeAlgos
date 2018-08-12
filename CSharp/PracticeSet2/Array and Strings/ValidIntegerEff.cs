public class Solution {
   public bool IsNumber(string s) {
        
        if (string.IsNullOrWhiteSpace(s)) return false;
        
        bool seenNum = false;
        bool seenE = false;
        bool seenD = false;
        
        s = s.Trim();
        for (int i=0; i < s.Length; ++i) {
            char c = s[i];
            switch(c) {
                case '.':
                    if (seenD || seenE) return false;
                    seenD = true;
                    break;
                case 'e':
                    if (seenE || !seenNum) return false;
                    seenE = true;
                    seenNum = false;
                    break;
                case '+':
                case '-':
                    if (i != 0 || s[i-1] != 'e') return false;
                    seenNum = false;
                    break;
                default:
                    if (c - '0' < 0 || c - '0' > 9) return false;
                    seenNum = true;
                    break;
            }
            
        }
        
        return seenNum;
    }
}