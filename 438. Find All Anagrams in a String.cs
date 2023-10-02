public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        if(p.Length > s.Length) return new List<int>();
        
        int[] freq = new int[26];
        int required = p.Length;
        IList<int> result = new List<int>();

        for(int i = 0; i < p.Length; i++)
        {
            ++freq[p[i] - 'a'];
        }

        for(int start = 0, end = 0; end < s.Length; end++)
        {
            if(--freq[s[end] - 'a'] >= 0) --required;

            while(required == 0)
            {
                if(end - start + 1 == p.Length) result.Add(start);
                if(++freq[s[start++] - 'a'] > 0) ++required;
            }
        }
        return result;
    }
}