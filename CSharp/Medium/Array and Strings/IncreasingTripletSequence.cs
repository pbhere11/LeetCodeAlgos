/*
Examples:
Given [1, 2, 3, 4, 5],
return true.

Given [5, 4, 3, 2, 1],
return false.
*/
public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        int firstNumber = int.MaxValue;
        int secondNumber = int.MaxValue;
        for(int i=0;i<nums.Length;i++)
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