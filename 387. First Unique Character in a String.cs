public class Solution {
    public int FirstUniqChar(string s) {
        int[] freq = new int[26];
        foreach(char ch in s)
        {
            freq[ch - 'a']++;
        }

        for(int idx = 0; idx < s.Length; idx++)
        {
            if(freq[s[idx] - 'a'] == 1) return idx;
        }
        return -1;
    }
}