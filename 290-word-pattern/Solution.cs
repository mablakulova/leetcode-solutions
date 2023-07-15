namespace LeetCode;

public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] words = s.Split(' ');
        var match = new Dictionary<char, string>();

        if (words.Length != pattern.Length)
        {
            return false;
        }

        for(int i = 0; i < pattern.Length; i++)
        {
            if (!match.ContainsKey(pattern[i]))
            {
                if (!match.ContainsValue(words[i]))
                {
                    match.Add(pattern[i], words[i]);
                }
                else 
                { 
                    return false; 
                }
            }
            else
            {
                if (match[pattern[i]] != words[i])
                {
                    return false;
                }
            }
        }

        return true;
    }
}