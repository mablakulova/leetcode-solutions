public class Solution {
    public int MissingNumber(int[] nums)
    {
        int len = nums.Length;
        int sum = 0, nSum = 0;
        
        foreach (int num in nums)
        {
            sum += num;
        }

        nSum = (1 + len) * len / 2;

        return nSum - sum;
    }
}

