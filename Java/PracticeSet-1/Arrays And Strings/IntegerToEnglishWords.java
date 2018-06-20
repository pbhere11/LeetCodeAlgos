/*
Example 1:

Input: 123
Output: "One Hundred Twenty Three"
Example 2:

Input: 12345
Output: "Twelve Thousand Three Hundred Forty Five"
Example 3:

Input: 1234567
Output: "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
*/
class Solution {
    public String numberToWords(int num) {
        HashMap<Integer,String> map = new HashMap<Integer,String>();
        map.put(0,"Zero");
        map.put(1,"One");
        map.put(2,"Two");
        map.put(3,"Three");
        map.put(4,"Four");
        map.put(5,"Five");
        map.put(6,"Six");
        map.put(7,"Seven");
        map.put(8,"Eight");
        map.put(9,"Nine");
        map.put(10,"Ten");
        map.put(11,"Eleven");
        map.put(12,"Twelve");
        map.put(13,"Thirteen");
        map.put(14,"Fourteen");
        map.put(15,"Fifteen");
        map.put(16,"Sixteen");
        map.put(17,"Seventeen");
        map.put(18,"Eighteen");
        map.put(19,"Nineteen");
        map.put(20,"Twenty");
        map.put(30,"Thirty");
        map.put(40,"Forty");
        map.put(50,"Fifty");
        map.put(60,"Sixty");
        map.put(70,"Seventy");
        map.put(80,"Eighty");
        map.put(90,"Ninety");
        map.put(90,"Ninety");
        String result = "";
        if(num==0)
        {
        	return map.get(num);
        }
        while(num>0)
        {
        	//billion
        	if(num>=1000000000)
        	{
        		int val = num/1000000000;
        		String str = convertForHundred(val,map);
        		result = result + " "  + str+" Billion";
        		num = num%1000000000;
        	}
        	//million
        	else if(num>=1000000)
        	{
        		int val = num/1000000;
        		String str = convertForHundred(val,map);
        		result = result + " "  + str+" Million";
        		num = num%1000000;
        	}
        	//thousand
        	else if(num>=1000)
        	{
        		int val = num/1000;
        		String str = convertForHundred(val,map);
        		result = result + " "  + str+" Thousand";
        		num = num%1000;
        	}
        	else
        	{
        		String str = convertForHundred(num,map);
        		result = result + " " + str;
        		num =0;
        	}

        }
        if(result.charAt(0)==' ')
        {
        	return result.substring(1);
        }
        else
        {
        	return result;
        }
        
    }
    private String convertForHundred(int num,HashMap<Integer,String> map)
    {
    	String result = "";
    	while(num>0)
    	{
    		if(num>=100)
			{
				int val = num/100;
				String str = convert(val,map);
				result = result + " " + str+" Hundred";
				num = num%100;
	        }
	        else
	        {
	        	String str = convert(num,map);
	        	result = result + " " + str;
	        	num =0;
	        }
    	}
    	if(result.charAt(0)==' ')
        {
        	return result.substring(1);
        }
        else
        {
        	return result;
        }
    	
    }

    private String convert(int num,HashMap<Integer,String> map)
    {
    	String result = "";
    	while(num>0)
    	{
    		if(num>20)
    		{
    			int val = num/10;
        		result = result + " " + map.get(val*10);
        		num = num%10;
    		}
    		else
    		{
    			result = result + " "+ map.get(num);
        		num = 0;
    		}
    	}
    	if(result.charAt(0)==' ')
        {
        	return result.substring(1);
        }
        else
        {
        	return result;
        }
    }
}