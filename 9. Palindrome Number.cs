public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        if(x == ReverseNumber(x)) return true;
        return false;
    }

    static int ReverseNumber(int x)
    {
        int rev_x = 0;

        while (x > 0)
        {
            rev_x = rev_x * 10 + x % 10;
            x /= 10;
        }

        return rev_x;
    }
}
