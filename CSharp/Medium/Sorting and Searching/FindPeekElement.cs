public class Solution {
    public int FindPeakElement(int[] nums) {
        return Search(nums,0,nums.Length-1);
    }
    private int Search(int[] nums, int l, int r)
    {
        if(l==r)
        {
            return l;
        }
        int mid = (l+r)/2;
        if(nums[mid]>nums[mid+1])
        {
            return Search(nums,l,mid);
        }
        else 
        {
            return Search(nums,mid+1,r);    
        }
    }
}

