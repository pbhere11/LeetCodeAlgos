class Solution {
    public int missingNumber(int[] nums) {
        int[] counter = new int[nums.length+1];
        Arrays.fill(counter,0);
        for(int i=0;i<nums.length;i++)
        {
        	counter[nums[i]]++;
        }
        for(int i=0;i<counter.length;i++)
        {
        	if(counter[i]==0)
        	{
        		return i;
        	}
        }
        return 0;
    }
}