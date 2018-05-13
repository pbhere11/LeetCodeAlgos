/*
nums = [1,1,2],
output = 2
nums = [0,0,1,1,1,2,2,3,3,4],
output = 5
i and j 

1,1,2
1,2 1

0,1,2,3,4,0,2,1,3,1


*/

class Solution {
    public int removeDuplicates(int[] nums) {
    	if(nums.length==0|| nums.length==1)
    	{
    		return nums.length;
    	}
        int i=1;
        int j =1;
        int prev = nums[0];//0

        while(j<nums.length)
        {
        	if(nums[j]!=prev)//4
        	{
        		prev = nums[j];//4
        		swap(nums,i,j);
        		i++;
        	}
        	j++;
        }
        return i;
    }
    private void swap(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}