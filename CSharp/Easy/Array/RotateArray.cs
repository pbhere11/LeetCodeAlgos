/*
Example 1:

Input: [1,2,3,4,5,6,7] and k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: [-1,-100,3,99] and k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]
*/
public class Solution {
    public void Rotate(int[] nums, int k) {
    	if(k>nums.Length )
        {
            k = k%nums.Length;
        }
        int pivot = nums.Length - k;
    	if(nums.Length>0 && k<=nums.Length)
    	{
    		Rotate(nums,0,pivot-1);
	        Rotate(nums,pivot,nums.Length-1);
	        Rotate(nums,0,nums.Length-1);
    	}
    }

    private void Rotate(int[] nums, int start, int end)
    {
    	if(start>=0&&start<nums.Length&&end>=0&&end<nums.Length)
    	{
    		while(start<end)
	    	{
	    		int temp = nums[start];
	    		nums[start] = nums[end];
	    		nums[end] = temp;
	    		start++;
	    		end--;
	    	}
    	}
    }
}