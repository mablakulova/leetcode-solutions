public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var myDictionary = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (myDictionary.ContainsKey(nums[i]))
            {
                if (i - myDictionary[nums[i]] <= k)
                    return true;
                else
                    myDictionary[nums[i]] = i;
            }
            else
                myDictionary.Add(nums[i], i);
        }

        return false;
    }
}
