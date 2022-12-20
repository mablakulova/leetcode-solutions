namespace LeetCode;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s) || s.Length == 1) return true;

        string stringWithCases = filterOutNonAlphanumbericaCharacters(s.ToLower());

        int start = 0;
        int end = stringWithCases.Length - 1;

        while (start < end)
        {
            char left = stringWithCases[start];
            char right = stringWithCases[end];

            if (left - right != 0)
            {
                return false;
            }

            start++;
            end--;
        }

        return true;
    }

    static string filterOutNonAlphanumbericaCharacters(string s)
    {
        return string.Concat(s.Where(c => char.IsLetterOrDigit(c) == true).ToArray());
    }
}

