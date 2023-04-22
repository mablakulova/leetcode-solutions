namespace LeetCode;

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int number_of_ones = 0;
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                number_of_ones++;
                max = Math.Max(max, number_of_ones);
            }
            else
            {
                number_of_ones = 0;
            }
        }
        return max;
    }
}