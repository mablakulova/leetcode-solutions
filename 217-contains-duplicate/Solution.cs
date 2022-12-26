namespace LeetCode;

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numbers = new HashSet<int>();
        foreach (int num in nums)
        {
            numbers.Add(num);
        }

        return numbers.Count != nums.Length;
    }
}

