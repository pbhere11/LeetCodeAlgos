/*
Example 1:

Input: [1,3,4,2,2]
Output: 2
Example 2:

Input: [3,1,3,4,2]
Output: 3
*/
class Solution {
    public int findDuplicate(int[] nums) {
        HashMap<Integer,Integer> map = new HashMap<Integer,Integer>();
        for(int i=0;i<nums.length;i++)
        {
        	if(map.containsKey(nums[i]))
        	{
        		map.put(nums[i],map.get(nums[i])+1);
        	}
        	else
        	{
        		map.put(nums[i],1);
        	}
        }
        for(int num: map.keySet())
        {
        	if(map.get(num)>1)
        	{
        		return num;
        	}
        }
        return -1;
    }
}