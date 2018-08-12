/*
Example 1:

Input: [3,0,1]
Output: 2
Example 2:

Input: [9,6,4,2,3,5,7,0,1]
Output: 8
*/
public class Solution {
    public int MissingNumber(int[] nums) {
        int expectedSum =0;
        int sum =0;
        for(int i=0;i<nums.Length;i++)
        {
        	expectedSum = expectedSum+i+1;
        	sum = sum+nums[i];
        }
        return expectedSum-sum;
    }
}