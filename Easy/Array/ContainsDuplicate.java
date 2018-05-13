/*
Input: [1,2,3,1]
Output: true
Input: [1,2,3,4]
Output: false
Input: [1,1,1,3,3,4,3,2,4,2]
Output: true

// sort - n(log n)
// inplace - n
// n log n


*/
class Solution {
    public boolean containsDuplicate(int[] nums) {
        HashSet<Integer> counter = new HashSet<Integer>();
        for(int i=0;i<nums.length;i++)
        {
        	if(counter.contains(nums[i]))
        	{
        		return true;
        	}
        	counter.add(nums[i]);
        }
        return false;
    }
}