public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] ans = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            if((i & 1) == 1)
            {
                ans[i] = nums[n + i / 2];
            }
            else
            {
                ans[i] = nums[i / 2];
            }
        }

        return ans;
    }
}