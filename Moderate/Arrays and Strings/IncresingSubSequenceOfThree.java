class Solution {
    public boolean increasingTriplet(int[] nums) {
		int firstNumber = Integer.MAX_VALUE;
		int secondNumber = Integer.MAX_VALUE;
		for(int i=0;i<nums.length;i++)
		{
			if(nums[i]<=firstNumber)
			{
				firstNumber = nums[i];
			}
			else if(nums[i]<=secondNumber)
			{
				secondNumber = nums[i];
			}
			else
			{
				return true;
			}
		}   
		return false;     
    }
}