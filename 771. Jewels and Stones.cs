public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        bool[] ar = new bool[128];
        for(int i = 0; i < jewels.Length; i++)
        {
            ar[jewels[i]] = true;
        }

        int count = 0;
        for(int j = 0; j < stones.Length; j++)
        {
            if(ar[stones[j]]) count++;
        }
        return count;
    }
}