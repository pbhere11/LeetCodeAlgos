/*
Given array nums = [-1, 0, 1, 2, -1, -4],

A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]
*/
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
    	IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        for(int i=0;i<nums.Length-2;i++)
        {
        	if(i==0||nums[i]!=nums[i-1])
        	{
        		int key = nums[i];
	        	int j = i+1;
	        	int k = nums.Length-1;
	        	while(j<k)
	        	{
	        		if(key+nums[j]+nums[k]==0)
	        		{
	        			IList<int> innerList = new List<int>();
	        			innerList.Add(key);
	        			innerList.Add(nums[j]);
	        			innerList.Add(nums[k]);
	        			result.Add(innerList);
	        			j++;
	        			k--;
	        			while(j<k && nums[j]==nums[j-1])
	        			{
	        				j++;
	        			}
	        			while(j<k && nums[k]==nums[k+1])
	        			{
	        				k--;
	        			}
	        		}
	        		else if(key+nums[j]+nums[k]<0)
	        		{
	        			j++;
	        		}
	        		else
	        		{
	        			k--;
	        		}
	        	}	
        	}
        }
        return result;
    }
}