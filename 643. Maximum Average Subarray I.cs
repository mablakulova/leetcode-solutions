public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int maxSum = 0, currentSum = 0;
        for(int i = 0; i < k; i++) currentSum += nums[i];
        maxSum = currentSum;

        for(int j = k; j < nums.Length; j++)
        {
            currentSum += nums[j] - nums[j - k];
            maxSum = Math.Max(maxSum, currentSum);
        }
        return (double)maxSum / k;
    }
}