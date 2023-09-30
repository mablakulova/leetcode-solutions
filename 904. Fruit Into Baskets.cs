public class Solution {
    public int TotalFruit(int[] fruits) {
        int start = 0, count = 0;
        var dict = new Dictionary<int, int>();

        for(int end = 0; end < fruits.Length; end++)
        {
            if(!dict.ContainsKey(fruits[end])) dict[fruits[end]] = 0;
            dict[fruits[end]]++;

            if(dict.Count > 2)
            {
                if(--dict[fruits[start]] == 0) dict.Remove(fruits[start]);
                start++;
            }
            count = Math.Max(count, end - start + 1);
        }
        return count;
    }
}