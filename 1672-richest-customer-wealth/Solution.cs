namespace LeetcodeLocalClasses
{
    public class Solution 
    {
        public int MaximumWealth(int[][] accounts)
        {
            int richest_wealth = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int temp_wealth = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                    temp_wealth += accounts[i][j];

                richest_wealth = richest_wealth > temp_wealth ? richest_wealth : temp_wealth;
            }

            return richest_wealth;
        }
    }
}