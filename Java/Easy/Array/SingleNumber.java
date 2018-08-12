/*
Input: [2,2,1]
Output: 1

Input: [4,1,2,1,2]
Output: 4

//sort - n log n
//bubble sort - n 
// total - n log n


*/
class Solution {
    public int singleNumber(int[] nums) {
        int x = 0;
        for(int i=0;i<nums.length;i++)
        {
        	x = x^nums[i];
        }
        return x;
    }
}