/*
Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/
class Solution {
    public int[] twoSum(int[] nums, int target) {
        int[] result = new int[2];
        HashMap<Integer,Integer> diffMap = new HashMap<Integer,Integer>();
        for(int i=0;i<nums.length;i++)
        {
        	if(!diffMap.containsKey(nums[i]))
        	{
        		diffMap.put(target-nums[i],i);
        	}
        	else
        	{
        		result[0] = diffMap.get(nums[i]);
        		result[1] = i;
        	}
        }
        return result;
    }
}