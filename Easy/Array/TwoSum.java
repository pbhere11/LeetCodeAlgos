class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer,Integer> counterMap = new HashMap<Integer,Integer>();
        int[] result = new int[2];
        for(int i=0;i<nums.length;i++)
        {
        	if(counterMap.containsKey(nums[i]))
        	{
        		result[0] = counterMap.get(nums[i]);
        		result[1] = i;
        		return result;
        	}
        	counterMap.put(target-nums[i],i);
        }
        return result;
    }
}