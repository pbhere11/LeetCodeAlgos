/*
Example 1:

Input: [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
             Total amount you can rob = 1 + 3 = 4.
Example 2:

Input: [2,7,9,3,1]
Output: 12
Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
             Total amount you can rob = 2 + 9 + 1 = 12.


*/
class Solution {
    public int rob(int[] nums) {
    	if(nums.length==0)
    	{
    		return 0;
    	}
    	if(nums.length==1)
    	{
    		return nums[0];
    	}
        int[] maxRobbery = new int[nums.length+1];
        maxRobbery[0] = nums[0];
        maxRobbery[1] = Math.max(nums[0],nums[1]);
        int maxRobbedVal = Math.max(maxRobbery[0],maxRobbery[1]);
        for(int i=2;i<nums.length;i++)
        {
        	maxRobbery[i] = Math.max(maxRobbery[i-1],nums[i] + maxRobbery[i-2]);
        	if(maxRobbery[i]>maxRobbedVal)
        	{
        		maxRobbedVal = maxRobbery[i];
        	}
        }
        return maxRobbedVal;
    }
}