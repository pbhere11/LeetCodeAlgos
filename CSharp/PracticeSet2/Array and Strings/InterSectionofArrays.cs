/*
Example:
Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].

Note:
Each element in the result should appear as many times as it shows in both arrays.
The result can be in any order.
*/
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int i=0;
        int j=0;
        IList<int> res = new List<int>();
        while(i<nums1.Length&&j<nums2.Length)
        {
            if(nums1[i]==nums2[j])
            {
            	res.Add(nums1[i]);
            	i++;
            	j++;
            }
            else if(nums1[i]<nums2[j])
            {
            	i++;
            }
            else
            {
            	j++;
            }
        }
        int[] result = new int[res.Count];
        for(int k =0;k<res.Count;k++)
        {
        	result[k] = res[k];
        }
        return result;
    }
}