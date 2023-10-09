public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1, j = b.Length - 1, carry = 0;
        StringBuilder sb = new StringBuilder();

        while(i >= 0 || j >= 0 || carry > 0)
        {
            carry += i >= 0 ? a[i--] - '0' : 0;
            carry += j >= 0 ? b[j--] - '0' : 0;
            sb.Insert(0, carry % 2);
            carry /= 2;
        }
        return sb.ToString();
    }
}