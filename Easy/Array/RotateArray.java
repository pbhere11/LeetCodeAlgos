/*
Input: [1,2,3,4,5,6,7] and k = 3
Output: [5,6,7,1,2,3,4]

1,2,3,4,5,6,7

4,3,2,1 7,6,5
5,6,7,1,2,3,4

Input: [-1,-100,3,99] and k = 2
Output: [3,99,-1,-100]

*/
class Solution {
    public void rotate(int[] nums, int k) {
        if(k>nums.length )
        {
            k = k%nums.length;
        }
        int pivot = nums.length - k;
        if(k<nums.length && nums.length > 1 && k>0)
        {
        	rotate(nums,0,pivot-1);
        	rotate(nums,pivot,nums.length-1);
        	rotate(nums,0,nums.length-1);
        }
    }
    private void rotate(int[]nums, int start, int end)
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