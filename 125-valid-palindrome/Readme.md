<h3><a href="https://leetcode.com/problems/valid-palindrome/description/">125. Valid Palindrome</a></h3><h4>Easy</h4><hr>

2-Solution
```cs
public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s) || s.Length == 1) return true;

        string stringWithCases = filterOutNonAlphanumbericaCharacters(s.ToLower());

        if(stringWithCases != ReverseString(stringWithCases)) return false;

        return true;
    }

    static string filterOutNonAlphanumbericaCharacters(string s)
    {
        return string.Concat(s.Where(c => char.IsLetterOrDigit(c) == true).ToArray());
    }

    static string ReverseString(string s)
    {
        var ar = s.ToCharArray();
        Array.Reverse(ar);
        return new String(ar);
    }
}
```

`Runtime`: 85 ms, beats 90.30%
`Memory`: 42.1 MB, beats 22.83%