public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var map = new Dictionary<int, int>();
        var list = new List<int>();
        for(int i = 0; i < nums1.Length; i++)
        {
            map[nums1[i]] = i;
        }

        for(int j = 0; j < nums2.Length; j++)
        {
            if(map.ContainsKey(nums2[j])) 
            {
                list.Add(nums2[j]);
                map.Remove(nums2[j]);
            }
        }

        return list.ToArray();
    }
}