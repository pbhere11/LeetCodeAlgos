/*
Input: [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]

[2,0,1]
[0,1,2]


2,0,2,1,1,0
0 0 1 1 2 2
*/

class Solution {
    public void sortColors(int[] nums) {
        int start =0;
        int end = nums.length-1;
        int index =0;

        while(index<=end)
        {
        	if(nums[index]==0)
        	{
        		int temp = nums[start];
        		nums[start]= nums[index];
        		nums[index] = temp;
        		start++;
        		index++;
        	}
        	else if(nums[index]==2)
        	{
        		int temp = nums[end];//1
        		nums[end]= nums[index];//2
        		nums[index] = temp;//1
        		end--;
        	}
        	else
        	{
        		index++;
        	}
        }
    }
}