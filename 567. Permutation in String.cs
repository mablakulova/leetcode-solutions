public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        int[] freq1 = new int[128], freq2 = new int[128];

        for (int i = 0; i < s1.Length; i++)
        {
            ++freq1[s1[i]];
            ++freq2[s2[i]];
        }

        if (Enumerable.SequenceEqual(freq1, freq2)) return true;

        for (int i = s1.Length; i < s2.Length; i++)
        {
            ++freq2[s2[i]];
            --freq2[s2[i - s1.Length]];

            if (Enumerable.SequenceEqual(freq1, freq2)) return true;
        }
        return false;
    }
}