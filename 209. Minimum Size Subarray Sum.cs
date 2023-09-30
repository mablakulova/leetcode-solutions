public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int minLen = Int32.MaxValue, sum = 0, start = 0;
        for(int end = 0; end < nums.Length; end++)
        {
            sum += nums[end];
            while(sum >= target)
            {
                minLen = Math.Min(minLen, end - start + 1);
                sum -= nums[start];
                start++;
            }
        }
        return (minLen == Int32.MaxValue) ? 0 : minLen;
    }
}