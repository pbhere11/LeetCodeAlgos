/*
nums1 = [1,2,3,0,0,0], m = 3
nums2 = [2,5,6],       n = 3

1 2 2 0 0 0 
3 5 6
*/
class Solution {
    public void merge(int[] nums1, int m, int[] nums2, int n) {
        if(nums1.length!=0 && nums2.length!=0)
        {
            int i=m-1;
            int j=n-1;
            for(int k=nums1.length-1;k>=0;k--)
            {
                if(j<0 ||(i>=0 && nums1[i]>nums2[j]))
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
            }
        }
    }
}