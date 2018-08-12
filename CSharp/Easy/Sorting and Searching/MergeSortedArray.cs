/*
Example:

Input:
nums1 = [1,2,3,0,0,0], m = 3
nums2 = [2,5,6],       n = 3

Output: [1,2,2,3,5,6]
*/
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        m--;
        n--;
        int i = nums1.Length-1;
        while(m>=0||n>=0)
        {
        	if(m<0)
        	{
        		nums1[i] = nums2[n];
        		n--;
        	}
        	else if(n<0)
        	{
        		nums1[i] = nums1[m];
        		m--;
        	}
        	else
        	{
        		if(nums1[m]>nums2[n])
        		{
        			nums1[i] = nums1[m];
        			m--;
        		}
        		else
        		{
        			nums1[i] = nums2[n];
        			n--;
        		}
        	}
        	i--;
        }
    }
}