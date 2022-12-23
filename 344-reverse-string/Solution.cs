namespace LeetCode;

public class Solution {
    public void ReverseString(char[] s)
    {
        int start = 0, end = s.Length - 1;

        while (start < end)
        {
            var temp = s[start];
            s[start++] = s[end];
            s[end--] = temp;
        }
    }
}

