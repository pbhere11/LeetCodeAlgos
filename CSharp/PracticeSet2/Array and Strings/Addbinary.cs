/*
Example 1:

Input: a = "11", b = "1"
Output: "100"
Example 2:

Input: a = "1010", b = "1011"
Output: "10101"
*/
public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length-1;
        int j = b.Length-1;
        int carry =0;
        StringBuilder sb = new StringBuilder();
        while(i>=0||j>=0)
        {
        	int num1 =0;
        	int num2 =0;
        	if(i<0)
        	{
        		num2 = (int)b[j]-'0';
        		j--;
        	}
        	else if(j<0)
        	{
        		num1 = (int)a[i]-'0';
        		i--;
        	}
        	else
        	{
        		num1 = (int)a[i]-'0';
        		num2 = (int)b[j]-'0';
        		i--;
        		j--;
        	}
        	int ans = num1 + num2 + carry;
        	if(ans ==0 || ans ==1)
        	{
        		sb.Insert(0,ans);
        		carry =0;
        	}
        	else if(ans==2)
        	{
        		sb.Insert(0,0);
        		carry = 1;
        	}
        	else
        	{
        		sb.Insert(0,1);
        		carry = 1;
        	}
        }
        if(carry==1)
        {
        	sb.Insert(0,1);
        }
        return sb.ToString();
    }
}