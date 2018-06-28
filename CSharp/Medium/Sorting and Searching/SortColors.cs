/*
Example:

Input: [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]

0,1,2,3,4,5
2,0,2,1,1,0
0,0,2,1,1,2
0,0,1,1,2,2
*/
public class Solution {
    public void SortColors(int[] nums) {
        int left = 0;
        int right = nums.Length-1;
        int index = 0;
        while(index<=right)
        {
        	if(nums[index] == 0)
        	{
        		Swap(nums,index,left);
        		left++;
        		index++;
        	}
        	else if(nums[index] == 2)
        	{
        		Swap(nums,index,right);
        		right--;
        	}
        	else if(nums[index] == 1)
        	{
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