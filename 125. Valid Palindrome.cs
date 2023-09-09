public class Solution 
{
    public bool IsPalindrome(string s) {
        char[] chars = s.Where(c => char.IsLetterOrDigit(c)).Select(c => char.ToLower(c)).ToArray();
        
        int l = 0;
        int r = chars.Length - 1;
        
        while (l < r)
        {
            if (chars[l] != chars[r]) return false;
            
            l++;
            r--;
        }
        
        return true;
    }
}