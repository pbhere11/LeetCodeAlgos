/*
Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]
*/
public class Solution {
    public void MoveZeroes(int[] nums) {
        int start =0;
        int index =0;
        while(index<nums.Length)
        {
        	if(nums[index]==0)
        	{
        		index++;
        	}
        	else
        	{
        		Swap(nums,index,start);
        		start++;
        		index++;
        	}
        }
    }
    private void Swap(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}