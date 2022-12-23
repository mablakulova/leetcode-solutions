<h3><a href="https://leetcode.com/problems/valid-anagram/description/">242. Valid Anagram</a></h3><h4>Easy</h4><hr>

2-Solution
```cs
public class Solution {
    public bool IsAnagram(string s, string t)
    {
        char[] arS = s.ToCharArray();
        char[] arT = t.ToCharArray();
        Array.Sort(arS);
        Array.Sort(arT);

        return new string(arS) == new string(arT);
    }
}
```
Sorting solution - Alphabetically sort each string, and compare them. This method is relatively slow, each sorting (quick sort) has O(nlogn) time complexity.

`Runtime`: 80 ms, beats 93.88%  `Memory`: 41 MB, beats 11.29%