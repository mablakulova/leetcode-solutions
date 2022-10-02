<h3><a href="https://leetcode.com/problems/running-sum-of-1d-array/">1480. Running Sum of 1d Array</a></h3><h4>Easy</h4><hr>

2-Solution
```cs
public class Solution {
    public int[] RunningSum(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            nums[i] = sum;
        }
        return nums;
    }
}
```

`Runtime`: 234 ms, faster than 38.35% of C# online submissions.
`Memory Usage`: 41.6 MB, less than 56.59% of C# online submissions.