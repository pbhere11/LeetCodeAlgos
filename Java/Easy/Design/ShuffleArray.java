class Solution {
	private int[] nums;
	private int[] ogNums;
    public Solution(int[] nums) {
        nums = this.nums;
        ognums = nums;
    }
    
    /** Resets the array to its original configuration and return it. */
    public int[] reset() {
        return ogNums;
    }
    
    /** Returns a random shuffling of the array. */
    public int[] shuffle() {
        
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.reset();
 * int[] param_2 = obj.shuffle();
 */