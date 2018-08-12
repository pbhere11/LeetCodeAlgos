/*
Example:

Input:
nums1 = [1,2,3,0,0,0], m = 3
nums2 = [2,5,6],       n = 3

Output: [1,2,2,3,5,6]
*/
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m-1;
        int j = n-1;
        int index = nums1.Length-1;
        while(i>=0||j>=0)
        {
			if(j<0)
        	{
        		nums1[index] = nums1[i];
        		i--;
        	}
        	else if(i<0)
        	{
        		nums1[index] = nums2[j];
        		j--;
        	}
        	else
        	{
        		if(nums2[j]>=nums1[i])
        		{
        			nums1[index] = nums2[j];
        			j--;
        		}
        		else
        		{
        			nums1[index] = nums1[i];
        			i--;
        		}
        	}
        	index--;
        }
    }
}