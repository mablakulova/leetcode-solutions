public class Solution 
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (numbers.ContainsKey(target - nums[i]))
            {
                return new int[] { i, numbers[target - nums[i]] };
            }
            else
            {
                numbers[nums[i]] = i;
            }
        }

        return new int[0];
    }
}

