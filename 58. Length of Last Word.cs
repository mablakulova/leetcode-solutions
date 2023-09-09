public class Solution 
{
    public int LengthOfLastWord(string s)
    {
        string trimmedString = s.Trim();
        int count = 0;

        for (int i = trimmedString.Length - 1; i >= 0; i--)
        {
            if (trimmedString[i] == ' ')
                return count;
            else
                count++;
        }

        return count;
    }
}

