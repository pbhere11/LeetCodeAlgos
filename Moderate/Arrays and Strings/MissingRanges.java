class Solution {
    public List<String> findMissingRanges(int[] nums, int lower, int upper) {
        List<String> result = new ArrayList<String>();
        if(nums.length==0)
        {
        	if(lower==upper)
        	{
        		result.add(""+lower);
        	}
        	else
        	{
        		int firstNumber = lower;
        		int secondNumber = upper;
        		result.add(""+firstNumber+"->"+secondNumber);
        	}
        	return result;
        }
        boolean lowerFound = false;
        for(int i=0;i<nums.length;i++)
        {
        	if(nums[i]>=lower && !lowerFound)
        	{
        		lowerFound = true;;
        		if(nums[i]!=lower)
        		{
        			result.add(addFirsttoList(lower,nums[i]));
        		}
        	}
        	else if(nums[i]>=upper && lowerFound)
        	{
        		if(nums[i]==upper && upper-nums[i-1]>1)
        		{
        			result.add(addLasttoList(nums[i-1],upper-1));
        		}
        		break;
        	}
        	else if(nums[i]-nums[i-1]>1 && lowerFound)
        	{
        		result.add(addOtherstoList(nums[i-1],nums[i]));
        	}
        }
        if(nums[nums.length-1]<upper)
        {
        	if(lowerFound)
        	{
        		result.add(addLasttoList(nums[nums.length-1],upper));
        	}
        	else
        	{
        		if(lower==upper)
	        	{
	        		result.add(""+lower);
	        	}
	        	else
	        	{
	        		int firstNumber = lower;
	        		int secondNumber = upper;
	        		result.add(""+firstNumber+"->"+secondNumber);
	        	}
        	}
        }
        return result;
    }
    private String addFirsttoList(int smaller,int greater)
    {
    	if(greater-smaller==1)
    	{
    		return smaller+"";
    	}
    	else
    	{
    		int first = smaller;
    		int second = greater-1;
    		return ""+first+"->"+second;
    	}
    }
    private String addOtherstoList(int smaller,int greater)
    {
    	if(greater-smaller==2)
    	{
    		int first = smaller+1;
    		return ""+first;
    	}
    	else
    	{
    		int first = smaller+1;
    		int second = greater-1;
    		return first+"->"+second;
    	}
    }
    private String addLasttoList(int smaller,int greater)
    {
    	if(greater-smaller==1)
    	{
    		return ""+greater;
    	}
    	else
    	{
    		int first = smaller+1;
    		int second = greater;
    		return first+"->"+second;
    	}
    }
}