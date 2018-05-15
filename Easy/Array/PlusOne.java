class Solution {
    public int[] plusOne(int[] digits) {
        List<Integer> result = new ArrayList<Integer>();
        int carry = 1;
        for(int i = digits.length-1;i>=0;i--)
        {
        	int ans = digits[i] + carry;
        	result.add(ans%10);
        	if(ans>=10)
        	{
        		carry = 1;
        	}
        	else
        	{
        		carry = 0;
        	}
        }

        if(carry>0)
        {
        	result.add(carry);
        }
        int[] rslt = new int[result.size()];
        int j =0;
        for(int i=result.size()-1;i>=0;i--)
        {
        	rslt[j] = result.get(i);
        	j++;
        }
        return rslt;
    }
}