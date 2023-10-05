public class Solution {
    public bool ValidPalindrome(string s)
    {
        int start = 0, end = s.Length - 1;

        while(start < end)
        {
            if (s[start] != s[end])
            {
                return (IsPalindrome(s, start + 1, end) || IsPalindrome(s, start, end - 1));
            }

            start++;
            end--;
        }
        return true;
    }

    private bool IsPalindrome(string s, int start, int end)
    {
        while(start < end)
        {
            if (s[start] != s[end]) return false;

            start++;
            end--;
        }
        return true;
    }
}