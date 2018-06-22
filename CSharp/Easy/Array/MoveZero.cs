/*
Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]
*/

public class Solution {
    public void MoveZeroes(int[] nums) {
        int index =0;
        for(int i=0;i<nums.Length;i++)
        {
        	if(nums[i]!=0)
        	{
        		nums[index] = nums[i];
        		index++;
        	}
        }
        for(int i=index;i<nums.Length;i++)
        {
        	nums[i] =0;
        }
    }
}