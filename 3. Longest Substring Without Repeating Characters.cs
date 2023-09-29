public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int start = 0, end = 0;
        int maxSubLength = 0;

        var set = new HashSet<char>();
        while(end < s.Length)
        {
            if(set.Add(s[end]))
            {
                maxSubLength = Math.Max(maxSubLength, end - start + 1);
                end++;
            }
            else
            {
                set.Remove(s[start]);
                start++;
            }
        }
        return maxSubLength;
    }
}