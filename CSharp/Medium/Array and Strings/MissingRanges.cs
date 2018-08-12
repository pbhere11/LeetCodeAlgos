/*
Example:

Input: nums = [0, 1, 3, 50, 75], lower = 0 and upper = 99,
Output: ["2", "4->49", "51->74", "76->99"]
*/
public class Solution {
    public IList<string> FindMissingRanges(int[] nums, int lower, int upper) {
 		IList<string> result = new List<string>();
 		int lastFoundValue = -1;
 		bool lowerFound = false;
 		for(int i=0;i<nums.Length;i++)
 		{
 			if(!lowerFound && nums[i]>=lower)
 			{
 				if(nums[i]!=lower)
	 			{
	 				result.Add(GetFormatedString(lower,nums[i]-1));
	 			}
 				lastFoundValue = nums[i];
				lowerFound = true;
 			}
 			else if(lowerFound && nums[i] >= lastFoundValue+1 && nums[i]>=upper)
 			{
 				if(nums[i]>=lastFoundValue+1 && nums[i]>upper)
 				{
 					result.Add(GetFormatedString(lastFoundValue+1,upper));
 				}
 				else if(nums[i]>lastFoundValue+1 && nums[i]==upper)
 				{
 					result.Add(GetFormatedString(lastFoundValue+1,upper-1));	
 				}
 				lastFoundValue = upper;
				break;
 			}
 			else if(lowerFound && nums[i] >= lastFoundValue+1)
 			{
 				if(nums[i] != lastFoundValue+1)
 				{
 					result.Add(GetFormatedString(lastFoundValue+1,nums[i]-1));
 				}
 				lastFoundValue = nums[i];
 			}
 		}  
 		if(lowerFound && lastFoundValue<upper)
 		{
 			result.Add(GetFormatedString(lastFoundValue+1,upper));
 		}    
 		if(!lowerFound)
 		{
 			result.Add(GetFormatedString(lower,upper));
 		}
 		return result; 
    }

    private string GetFormatedString(int num1, int num2)
    {
    	if(num1==num2)
    	{
    		return num1.ToString();
    	}
    	else
    	{
    		StringBuilder sb = new StringBuilder();
    		sb.Append(num1);
    		sb.Append("->");
    		sb.Append(num2);
    		return sb.ToString();
    	}
    }
}