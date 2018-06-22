/*
Example 1:

Input: [2,2,1]
Output: 1
Example 2:

Input: [4,1,2,1,2]
Output: 4
*/
public class Solution {
    public int SingleNumber(int[] nums) {
        for(int i=1;i<nums.Length;i++)
        {
        	nums[0] =nums[0]^nums[i];
        }
        return nums[0];
    }
}