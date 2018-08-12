/*
Example 1:

Input: [2,2,1]
Output: 1
Example 2:

Input: [4,1,2,1,2]
Output: 4
*/
class Solution {
    public int singleNumber(int[] nums) {
        int x = 0;
        for(int i=0;i<nums.length; i++)
        {
            x = x^nums[i];
        }
        return x;
    }
}