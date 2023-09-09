public class Solution {
    public bool IsAnagram(string s, string t)
    {
        int[] alphabet = new int[26];
        foreach (var byt in Encoding.ASCII.GetBytes(s))
        {
            alphabet[byt - 97]++;
        }
        foreach (var byt in Encoding.ASCII.GetBytes(t))
        {
            alphabet[byt - 97]--;
        }
        foreach (var count in alphabet)
            if (count != 0) return false;
        return true;
    }
}

