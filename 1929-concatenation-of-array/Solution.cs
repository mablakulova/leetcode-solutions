namespace LeetCode;

public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len = nums.Length;
        int[] ans = new int[2 * len];
        
        for(int i = 0; i < len; i++){
            ans[i] = ans[len + i] = nums[i];
        }

        return ans;
    }
}