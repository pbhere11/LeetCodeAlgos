/*
Example 1:

Input: numerator = 1, denominator = 2
Output: "0.5"
Example 2:

Input: numerator = 2, denominator = 1
Output: "2"
Example 3:

Input: numerator = 2, denominator = 3
Output: "0.(6)"
*/
public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
    	StringBuilder sb = new StringBuilder();
    	if(denominator==0)
    	{
    		return "";
    	}
    	if(numerator==0)
    	{
    		return "0";
    	}
    	if(denominator==1)
    	{
    		return numerator.ToString();
    	}
    	int sign = 1;
    	if(numerator<0)
    	{
    		if(numerator==int.MinValue)
    		{
    			numerator = int.MaxValue;
    		}
    		else
    		{
    			numerator = -1*numerator;
    		}
    		sign = -1*sign;
    	}
    	if(denominator<0)
    	{
    		if(denominator==int.MinValue)
    		{
    			denominator = int.MaxValue;
    		}
    		else
    		{
    			denominator = -1*denominator;
    		}
    		sign = -1*sign;
    	}
        long quotient = numerator/denominator;
		long reminder = numerator%denominator;
		if(sign<0)
		{
			sb.Append("-");
		}
		sb.Append(quotient);
		if(reminder==0)
		{
			return sb.ToString();
		}
		else
		{
			sb.Append(".");
			Dictionary<long,int> map = new Dictionary<long,int>();
			long num =0;
			while(reminder!=0)
			{
				if(map.ContainsKey(reminder))
				{
					int index = map[reminder];
					sb.Insert(index,"(");
					sb.Append(")");
					break;
				}
				map.Add(reminder,sb.Length);
				num = reminder*10;
				quotient = num/denominator;
				reminder = num%denominator;
				sb.Append(quotient);
			}
			return sb.ToString();
		}
    }
}