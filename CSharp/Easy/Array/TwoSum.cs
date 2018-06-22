/*
Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> diffMap = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
        	if(diffMap.ContainsKey(nums[i]))
        	{
        		return new int[]{diffMap[nums[i]],i};
        	}
        	else
        	{
        		if(!diffMap.ContainsKey(target-nums[i]))
        		{
        			diffMap.Add(target-nums[i],i);
        		}
        	}
        }
        return new int[]{};
    }
}