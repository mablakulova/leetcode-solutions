<h3><a href="https://leetcode.com/problems/richest-customer-wealth/">1672. Richest Customer Wealth</a></h3><h4>Medium</h4><hr>

2-Solution using Linq:
```cs
public class Solution {
    public int MaximumWealth(int[][] accounts) {
        return accounts.Max(x => x.Sum());
    }
}
```

`Runtime`: 85 ms, faster than 97.66% of C# online submissions.
`Memory Usage`: 39.3 MB, less than 6.11% of C# online submissions.
